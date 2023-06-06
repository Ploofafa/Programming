using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public partial class Contact : ObservableObject, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// Словарь, который хранит все ошибки свойств которые есть у <see cref="Contact"/>.
        /// Ошибки хранятся в виде <key: propertyName, value: errorMessage>
        /// </summary>
        private Dictionary<string, string> Errors = new Dictionary<string, string>();

        /// <summary>
        /// Хранит имя контакта.
        /// </summary>с
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Хранит email контакта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Хранит номер телефона контакта. 
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

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

        /// <summary>
        /// Свойство, показывающее наличие ошибок у <see cref="Contact"/>.
        /// Возвращает <see cref="true"/>, если в <see cref="Errors"/> есть
        /// хотя бы одна запись. Если записей нет возвращает false.
        /// </summary>
        public bool HasError => Errors.Any();

        /// <summary>
        /// Возвращает пустую строку, не требует реализации.
        /// </summary>
        public string Error => String.Empty;

        /// <summary>
        /// Индексатор, которое проверяет наличие ошибок в данных <see cref="Contact"/>
        /// </summary>
        /// <param name="propertyName">Имя свойства проверяемого на наличие ошибок</param>
        /// <returns>Возвращает либо пустую строку, если ошибок нет, либо сообщение об ошибке.</returns>
        public string this[string propertyName]
        {
            get
            {
                Errors.Clear();
                CollectErrors();
                return Errors.ContainsKey(propertyName) ? Errors[propertyName] : string.Empty;
            }
        }

        /// <summary>
        /// Метод, который обновляет словарь <see cref="Errors"/>.
        /// Проверяет каждое свойство на ограничения.
        /// </summary>
        private void CollectErrors()
        {
            if (Name?.Length == 0)
            {
                Errors.Add(nameof(Name), "Name is required");
            }

            if (Name?.Length > 100)
            {
                Errors.Add(nameof(Name), "Name must be less than 100 characters.");
            }

            if (PhoneNumber?.Length > 100)
            {
                Errors.Add(nameof(PhoneNumber), "Name must be less than 100 characters.");
            }

            if (Email?.Length > 100)
            {
                Errors.Add(nameof(Email), "Name must be less than 100 characters.");
            }

            if (Email != null && !Email.Contains("@"))
            {
                Errors.Add(nameof(Email), "Name must contain symbol: @");
            }
        }
    }
}
