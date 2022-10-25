using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы, которые загружают и сохраняют данные.
    /// </summary>
    public static class ItemSerializer
    {
        /// <summary>
        /// Путь к файлу сохранения.
        /// </summary>
        private static string _fileName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\ObjectOrientedPractics\Items";

        /// <summary>
        /// Путь к папке сохранения.
        /// </summary>
        private static string _folderName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\ObjectOrientedPractics";

        /// <summary>
        /// Метод, который проверяет существует ли файл. Если не существует, то создаёт.
        /// </summary>
        private static void СheckFile()
        {
            if (!Directory.Exists(_folderName))
            {

                Directory.CreateDirectory(_folderName);
            }

            else if (!File.Exists(_fileName))
            {
                FileStream fileStream = new FileStream(_fileName, FileMode.Create);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Сохраняет все данные о товарах в файл.
        /// </summary>
        /// <param name="items">Список товаров, которые нужно сохранить.</param>
        /// <exception cref="NotImplementedException">Возникает, если произошла ошибка при сохранении.</exception>
        public static void SaveItemsToFile(List<Item> items)
        {
            try
            {
                СheckFile();
                StreamWriter streamWriter = new StreamWriter(_fileName);
                var jsonItems = JsonConvert.SerializeObject(items);
                streamWriter.Write(jsonItems);
                streamWriter.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Загружает данные из файла и передаёт их в список.
        /// </summary>
        /// <returns>Возвращает список товаров.</returns>
        public static List<Item> LoadItemsToFile()
        {
            СheckFile();
            StreamReader streamReader = new StreamReader(_fileName);
            var data = streamReader.ReadToEnd();
            var jsonItem = JsonConvert.DeserializeObject<List<Item>>(data);
            streamReader.Close();
            if (jsonItem == null)
            {
                return new List<Item>();
            }
            return jsonItem;
        }
    }
}
