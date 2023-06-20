using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public partial class Contact : ObservableValidator, ICloneable, INotifyDataErrorInfo
    {
        /// <summary>
        /// Хранит имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит email контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит номер телефона контакта. 
        /// </summary>
        private string _phoneNumber;

        [Required]
        [MaxLength(100)]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, true);
        }

        
        [MaxLength(100)]
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value, true);
        }

        
        [Required]
        [MaxLength(100)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetProperty(ref _phoneNumber, value, true);
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Конструктор для создания экземпляра класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Переменная, хранящая имя контакта.</param>
        /// <param name="phoneNumber">Переменная, хранящая номер контакта.</param>
        /// <param name="email">Переменная, хранящая почту контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        /// <summary>
        /// Создаёт клон контакта.
        /// </summary>
        /// <returns>Клонированный контакт.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }
    }
}
