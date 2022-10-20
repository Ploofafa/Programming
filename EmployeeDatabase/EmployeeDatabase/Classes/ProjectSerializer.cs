using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace EmployeeDatabase.Classes
{
    /// <summary>
    /// Предоставляет методы, которые загружают и сохраняют данные.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь к файлу сохранения.
        /// </summary>
        private static string _fileName = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\EmployeeDatabase";

        /// <summary>
        /// Метод, который проверяет существует ли файл. Если не существует, то создаёт.
        /// </summary>
        private static void СheckFile()
        {
            if (!File.Exists(_fileName))
            {
                FileStream fileStream = new FileStream(_fileName, FileMode.Create);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Сохраняет все данные о работнках в файл.
        /// </summary>
        /// <param name="employees">Список раюотников, которые нужно сохранить.</param>
        /// <exception cref="NotImplementedException">Возникает, если произошла ошибка при сохранении.</exception>
        public static void SaveEmployeesToFile(List<Employee> employees)
        {
            СheckFile();
            StreamWriter streamWriter = new StreamWriter(_fileName);
            var jsonEmployees = JsonConvert.SerializeObject(employees);
            streamWriter.Write(jsonEmployees);
            streamWriter.Close();
        }

        /// <summary>
        /// Загружает данные из файла и передаёт их в список.
        /// </summary>
        /// <returns>Возвращает список работников.</returns>
        public static List<Employee> LoadEmployeesToFile()
        {
            StreamReader streamReader = new StreamReader(_fileName);
            var data = streamReader.ReadToEnd();
            var jsonEmployee = JsonConvert.DeserializeObject<List<Employee>>(data);
            streamReader.Close();
            if (jsonEmployee == null)
            {
                return new List<Employee>();
            }
            return jsonEmployee;
        }
    }
}