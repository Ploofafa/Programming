using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Classes;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы, отвечающие за загрузку и сохранение данных.
    /// </summary>
    internal class StoreSerializer
    {
        /// <summary>
        /// Путь к файлу с сохранёнными товарами.
        /// </summary>
        private static string _itemsFilePath = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\KostryginMaxim\ItemsData";

        /// <summary>
        /// Путь к файлу с сохранёнными покупателями.
        /// </summary>
        private static string _customersFilePath = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\KostryginMaxim\CustomersData";

        /// <summary>
        /// Путь к папке сохранения.
        /// </summary>
        private static string _folderName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\KostryginMaxim";

        /// <summary>
        /// Метод, который проверяет существует ли файл. Если не существует, то создаёт.
        /// </summary>
        private static void СheckFile(string _filePath)
        {
            if (!Directory.Exists(_folderName))
            {

                Directory.CreateDirectory(_folderName);
            }

            if (!File.Exists(_filePath))
            {
                FileStream fileStream = new FileStream(_filePath, FileMode.Create);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="items">Путь к файлу, в который нужно сохранить данные.</param>
        public static void SaveData(List<Item> items)
        {
            СheckFile(_itemsFilePath);
            StreamWriter streamWriter = new StreamWriter(_itemsFilePath);
            var jsonData = JsonConvert.SerializeObject(items);
            streamWriter.Write(jsonData);
            streamWriter.Close();
        }

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="items">Путь к файлу, в который нужно сохранить данные.</param>
        public static void SaveData(List<Customer> customer)
        {
            СheckFile(_customersFilePath);
            StreamWriter streamWriter = new StreamWriter(_customersFilePath);
            var jsonData = JsonConvert.SerializeObject(customer);
            streamWriter.Write(jsonData);
            streamWriter.Close();
        }

        /// <summary>
        /// Загружает данные о товарах из файла.
        /// </summary>
        /// <returns>Возвращает список загруженных товаров.</returns>
        public static List<Item> LoadItemsData()
        {
            СheckFile(_itemsFilePath);
            StreamReader streamReader = new StreamReader(_itemsFilePath);
            var data = streamReader.ReadToEnd();
            streamReader.Close();
            var convertedData = JsonConvert.DeserializeObject<List<Item>>(data);
            return convertedData;
        }

        /// <summary>
        /// Загружает данные о покупателях из файла.
        /// </summary>
        /// <returns>Возвращает список загруженных покупателей.</returns>
        public static List<Customer> LoadCustomersData()
        {
            СheckFile(_customersFilePath);
            StreamReader streamReader = new StreamReader(_customersFilePath);
            var data = streamReader.ReadToEnd();
            streamReader.Close();
            var convertedData = JsonConvert.DeserializeObject<List<Customer>>(data);
            return convertedData;
        }
    }
}
