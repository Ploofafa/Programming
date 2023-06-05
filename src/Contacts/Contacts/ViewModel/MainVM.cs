using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using Contacts.Model.Services;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Класс, реализующий связь между GUI и бизнес-логикой.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит выбранный из <see cref="ListBox"/> экземпляр класса <see cref="Contact"/> в 
        /// <see cref="ObservableCollection{Contact}"/> для связи с View.
        /// </summary>
        private Contact? _selectedContact = new Contact();

        [RelayCommand]
        private void Add()
        {
            ViewingMode = false;
            SelectedContact = new Contact();
        }

        [RelayCommand(CanExecute = nameof(CanEditOrRemove))]
        private void Remove()
        {
            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            ChangeSelectAfterRemove(index);
        }

        [RelayCommand(CanExecute = nameof(CanEditOrRemove))]
        private void Edit()
        {
            ViewingMode = false;
            CloneContact = (Contact)SelectedContact.Clone();
        }

        private bool CanEditOrRemove()
        {
            return Contacts.Count > 0 && SelectedContact != null;
        }

        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply()
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
        }

        private bool CanApply()
        {
            return SelectedContact.IsValid;
        }

        /// <summary>
        /// Задаёт и возвращат клон экземпляра <see cref="Contact"/> выбранный в
        /// <see cref="ListBox"/> для присваивания его значений при отмене редактирования
        /// экземпляру в <see cref="ObservableCollection{Contact}"/>.
        /// </summary>
        private Contact? CloneContact { get; set; }

        /// <summary>
        /// Поле, хранящее значение видимости и читаемости 
        /// элементов управления, которые могут храниться.
        /// </summary>
        [ObservableProperty]
        private bool _viewingMode = true;

        /// <summary>
        /// Коллекция экземпляров класса <see cref="Contact"/>.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        /// <summary>
        /// Задаёт и возвращает выбранного контакта в листбоксе.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
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
    }
}
