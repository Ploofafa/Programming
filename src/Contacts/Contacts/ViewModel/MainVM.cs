    using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
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
        /// Хранит выбранный экземпляр класса <see cref="Contact"/> в 
        /// <see cref="ObservableCollection{T}"/> для связи с View.
        /// </summary>
        private Contact _selectedContact;

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

        private Contact CloneContact { get; set; }

        private bool _isReadOnly = true;

        public ObservableCollection<Contact> Contacts{ get; set; } = new ObservableCollection<Contact>();

        public bool IsVisible
        {
            get
            {
                return !_isReadOnly;
            }

            private set
            {
                _isReadOnly = !value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }

            private set
            {
                _isReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        public Contact SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                if (IsVisible == true && CloneContact != null)
                {
                    _selectedContact.Name = CloneContact.Name;
                    _selectedContact.Email = CloneContact.Email;
                    _selectedContact.PhoneNumber = CloneContact.PhoneNumber;
                    CloneContact = null;
                    IsVisible = false;
                    IsReadOnly = true;
                }
                else if (Contacts.IndexOf(_selectedContact) == -1)
                {
                    IsVisible = false;
                    IsReadOnly = true;
                }
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ?? new RelayCommand(obj =>
                {
                    IsVisible = true;
                    IsReadOnly = false;
                    SelectedContact  = new Contact();
                });
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? new RelayCommand(obj => 
                {
                    int index = Contacts.IndexOf(SelectedContact);
                    Contacts.Remove(SelectedContact);
                    if (Contacts.Count > 0 && Contacts.Count - 1 >= index)
                    {
                        SelectedContact = Contacts[index];
                    }
                    else if (Contacts.Count >= 1)
                    {
                        SelectedContact = Contacts[index - 1];
                    }
                    else
                    {
                        SelectedContact = null;
                    }
                }, 
                    (obj) => Contacts.Count > 0 && SelectedContact != null);
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ?? new RelayCommand(obj =>
                {
                    IsVisible = true;
                    IsReadOnly = false;
                    CloneContact = (Contact)SelectedContact.Clone();
                },
                (obj) => Contacts.Count > 0 && SelectedContact != null);
            }
        }

        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ?? new RelayCommand(obj =>
                {
                    IsVisible = false;
                    IsReadOnly = true;
                    if (Contacts.IndexOf(SelectedContact) == -1)
                    {
                        Contacts.Add(SelectedContact);
                    }
                });
            }
        }

        public void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        public void LoadContacts()
        {
            Contacts = ContactSerializer.LoadContact();
        }

        public MainVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
