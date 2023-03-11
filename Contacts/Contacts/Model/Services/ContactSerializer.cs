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
        private static string _fileName = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + @"\Contacts\contacts.Json";

        /// <summary>
        /// Метод, который проверяет существует ли файл. Если не существует, то создаёт.
        /// </summary>
        public static void СheckFile()
        {
            if (!File.Exists(_fileName))
            {
                FileStream fileStream = new FileStream(_fileName, FileMode.Create);
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
            StreamWriter streamWriter = new StreamWriter(_fileName);
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
            StreamReader streamReader = new StreamReader(_fileName);
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
