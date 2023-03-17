using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase.Classes
{

    /// <summary>
    /// Содержит информацию о работнике: полное ФИО, ЗП, дата трудоустройства.
    /// </summary>
    public class Employee
    {

        /// <summary>
        /// ФИО. Не более 100 символов.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// ЗП. Не больше 500 000, больше 0.
        /// </summary>
        private int _salary;

        /// <summary>
        /// Дата трудоустройства. Не позднее настоящего момента.
        /// </summary>
        private DateTime _employmentDate;

        /// <summary>
        /// Должность. Не более 50 символов.
        /// </summary>
        private string _jobTitle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Employee"/>.
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Employee"/>.
        /// </summary>
        /// <param name="fullName">Имя. Не более 100 символов.</param>
        /// <param name="salary">ЗП. От 0 до 500 000.</param>
        /// <param name="employmentDate">Дата трудоустройства. Не позднее настоящего момента.</param>
        /// <param name="jobTitle">Должность. Не более 50 символов.</param>
        public Employee(string fullName, int salary, 
               DateTime employmentDate, string jobTitle)
        {
            FullName = fullName;
            Salary = salary;
            EmploymentDate = employmentDate;
            JobTitle = jobTitle;

        }
        
        /// <summary>
        /// ФИО. Не более 100 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 100);
                Validator.AssertStringContainsOnlyLetters(value);
                _fullName = value;
            }
        }

        /// <summary>
        /// ЗП. От 0 до 500 000.
        /// </summary>
        public int Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 500000);
                _salary = value;
            }
        }

        /// <summary>
        /// Дата трудоустройства. Не позднее настоящего момента.
        /// </summary>
        public DateTime EmploymentDate
        {
            get 
            { 
                return _employmentDate; 
            }

            set
            {
                Validator.AssertOnCorrectDate(value);
                _employmentDate = value;
            }
        }

        /// <summary>
        /// Должность. Не более 50 символов.
        /// </summary>
        public string JobTitle
        {
            get
            {
                return _jobTitle;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 50);
                _jobTitle = value;
            }
        }
    }
}
