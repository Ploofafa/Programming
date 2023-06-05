using System;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Класс, предоставляющий методы для сохранения и загрузки контактов.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Хранит путь к папке сохранения и загрузки.
        /// </summary>
        private static string _folderName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\Contacts";

        /// <summary>
        /// Хранит путь к файлу сохранения и загрузки
        /// </summary>
        private static string _contactFilePath = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\Contacts\ContactData";

        /// <summary>
        /// Метод, который проверяет существует ли файл. Если не существует, то создаёт.
        /// </summary>
        private static void СheckFile()
        {
            if (!Directory.Exists(_folderName))
            {

                Directory.CreateDirectory(_folderName);
            }

            if (!File.Exists(_contactFilePath))
            {
                FileStream fileStream = new FileStream(_contactFilePath, FileMode.Create);
                fileStream.Close();
            }
        }
        
        /// <summary>
        /// Метод, который записывает контакт в файл.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public static void SaveContacts(ObservableCollection<Contact> contacts)
        {
            СheckFile();
            StreamWriter streamWriter = new StreamWriter(_contactFilePath);
            var jsonContacts = JsonConvert.SerializeObject(contacts);
            streamWriter.Write(jsonContacts);
            streamWriter.Close();
        }

        /// <summary>
        /// Метод, который загружает данные из файла.
        /// </summary>
        /// <param name="contact">Загруженный контакт.</param>
        /// <returns></returns>
        public static ObservableCollection<Contact> LoadContact()
        {
            СheckFile();
            StreamReader streamReader = new StreamReader(_contactFilePath);
            var data = streamReader.ReadToEnd();
            var jsonContacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(data);
            streamReader.Close();
            if( jsonContacts == null)
            {
                return new ObservableCollection<Contact>();
            }

            return jsonContacts;
        }
    }
}
