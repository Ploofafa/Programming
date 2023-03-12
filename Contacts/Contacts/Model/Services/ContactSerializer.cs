using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model;
using Newtonsoft.Json;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Класс, предоставляющий методы для сохранения и загрузки контактов.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Хранит путь к файлу сохранения и загрузки.
        /// </summary>
        private static string _folderName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\Contacts";

        private static string _ContactFilePath = Environment.GetFolderPath(
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

            if (!File.Exists(_ContactFilePath))
            {
                FileStream fileStream = new FileStream(_ContactFilePath, FileMode.Create);
                fileStream.Close();
            }
        }
        
        /// <summary>
        /// Метод, который записывает контакт в файл.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public static void SaveContact(Contact contact)
        {
            СheckFile();
            StreamWriter streamWriter = new StreamWriter(_ContactFilePath);
            var jsonContact = JsonConvert.SerializeObject(contact);
            streamWriter.Write(jsonContact);
            streamWriter.Close();
        }

        /// <summary>
        /// Метод, который загружает данные из файла.
        /// </summary>
        /// <param name="contact">Загруженный контакт.</param>
        /// <returns></returns>
        public static Contact LoadContact(Contact contact)
        {
            StreamReader streamReader = new StreamReader(_ContactFilePath);
            var data = streamReader.ReadToEnd();
            var jsonContact = JsonConvert.DeserializeObject<Contact>(data);
            streamReader.Close();
            if( jsonContact == null)
            {
                return new Contact();
            }

            return jsonContact;
        }
    }
}
