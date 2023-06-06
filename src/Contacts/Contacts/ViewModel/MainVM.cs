using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Класс, реализующий связь между GUI и бизнес-логикой.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит выбранный из <see cref="ListBox"/> экземпляр класса <see cref="Contact"/> в 
        /// <see cref="ObservableCollection{Contact}"/> для связи с View.
        /// </summary>
        private Contact _selectedContact = new Contact();

        /// <summary>
        /// Хранит экземпляр класса <see cref="RelayCommand"/>.
        /// Реализует команду добавления контакта в коллекцию.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Хранит экземпляр класса <see cref="RelayCommand"/>.
        /// Реализует команду удаления контакта из коллекции.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Хранит экземпляр класса <see cref="RelayCommand"/>.
        /// Реализует команду редактирования контакта в коллекции.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Хранит экземпляр класса <see cref="RelayCommand"/>.
        /// Реализует команду для применения изменений контакта в коллекции.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Задаёт и возвращат клон экземпляра <see cref="Contact"/> выбранный в
        /// <see cref="ListBox"/> для присваивания его значений при отмене редактирования
        /// экземпляру в <see cref="ObservableCollection{Contact}"/>.
        /// </summary>
        private Contact CloneContact { get; set; }

        /// <summary>
        /// Поле, хранящее значение видимости и читаемости 
        /// элементов управления, которые могут храниться.
        /// </summary>
        private bool _viewingMode = true;

        /// <summary>
        /// Коллекция экземпляров класса <see cref="Contact"/>.
        /// </summary>
        public ObservableCollection<Contact> Contacts{ get; set; } = new ObservableCollection<Contact>();

        /// <summary>
        /// Задаёт и возвращает значение включённости режима просмотра.
        /// </summary>
        public bool ViewingMode
        {
            get
            {
                return _viewingMode;
            }

            private set
            {
                _viewingMode = value;
                OnPropertyChanged(nameof(ViewingMode));
            }
        }

        /// <summary>
        /// Задаёт и возвращает выбранного контакта в листбоксе.
        /// </summary>
        public Contact SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                if (ViewingMode == false && CloneContact != null)
                {
                    UndoChanges();
                }
                else if (Contacts.Count > 0 && Contacts.IndexOf(_selectedContact) == -1)
                {
                    UndoCreate();
                }
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Метод для отмены изменений при редактировании.
        /// </summary>
        private void UndoChanges()
        {
            _selectedContact.Name = CloneContact.Name;
            _selectedContact.Email = CloneContact.Email;
            _selectedContact.PhoneNumber = CloneContact.PhoneNumber;
            CloneContact = null;
            ViewingMode = true;
        }
        
        /// <summary>
        /// Метод для отмены создания контакта.
        /// </summary>
        private void UndoCreate()
        {
            _selectedContact = null;
            ViewingMode = true;
        }

        /// <summary>
        /// Команда для добавления контакта в список.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ?? new RelayCommand(obj =>
                {
                    ViewingMode = false;
                    SelectedContact  = new Contact();
                });
            }
        }

        /// <summary>
        /// Команда для удаления контакта из списка.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? new RelayCommand(obj => 
                {
                    int index = Contacts.IndexOf(SelectedContact);
                    Contacts.Remove(SelectedContact);
                    ChangeSelectAfterRemove(index);
                }, 
                    (obj) => Contacts.Count > 0 && SelectedContact != null && Contacts.Contains(SelectedContact));
            }
        }

        /// <summary>
        /// Метод, определяющий, какой после удаления контакта будет выбран 
        /// элемент.
        /// </summary>
        /// <param name="index">Индекс удаляемого контакта.</param>
        private void ChangeSelectAfterRemove(int index)
        {
            if (Contacts.Count > 0 && Contacts.Count - 1 >= index)
            {
                SelectedContact = Contacts[index];
                return;
            }

            if (Contacts.Count >= 1)
            {
                SelectedContact = Contacts[index - 1];
                return;
            }
            SelectedContact = null;            
        }

        /// <summary>
        /// Командаа для изменения контакта из списка.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ?? new RelayCommand(obj =>
                {
                    ViewingMode = false;
                    CloneContact = (Contact)SelectedContact.Clone();
                },
                (obj) => Contacts.Count > 0 && SelectedContact != null && Contacts.Contains(SelectedContact));
            }
        }

        /// <summary>
        /// Команда для применения изменений контакта.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ?? new RelayCommand(obj =>
                {
                    ViewingMode = true;
                    if (Contacts.IndexOf(SelectedContact) == -1)
                    {
                        Contacts.Add(SelectedContact);
                    }
                    if (CloneContact != null)
                    {
                        CloneContact = null;
                    }
                }, obj => 
                {
                    if (SelectedContact != null)
                    {
                        return !SelectedContact.IsValid;
                    }
                    return false;
                });
            }
        }

        /// <summary>
        /// Метод для сохранения списка контактов.
        /// </summary>
        public void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Метод для выгрузки списка контактов в приложение.
        /// </summary>
        public void LoadContacts()
        {
            Contacts = ContactSerializer.LoadContact();
            if (Contacts.Count > 0)
            {
                SelectedContact = Contacts[0];
            }
        }

        public MainVM()
        {
        }

        /// <summary>
        /// Событие на изменения свойства для связи View и Model.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод, вызывающийся при изменении свойства.
        /// </summary>
        /// <param name="property">Имя свойства, которое его вызвало</param>
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
