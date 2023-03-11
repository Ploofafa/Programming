using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model;

namespace Contacts.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Contact _contact;

        public MainVM()
        {
            _contact = new Contact();
        }

        public string Name
        {
            get
            {
                return _contact.Name;
            }

            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Email
        {
            get
            {
                return _contact.Email;
            }

            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
