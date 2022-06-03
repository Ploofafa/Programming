using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит инфомацию о дисциплине:
    /// имя студента, оценка, имя преподователя, дисциплина.
    /// </summary>
    public class Subject
    {

        /// <summary>
        /// Оценка. Может лежать в промежутке от 0 до 100.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject() 
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="rating">Оценка. Может лежать в промежутке от 0 до 100.</param>
        /// <param name="studentName">Имя студента.</param>
        /// <param name="teacherName">Имя преподавателя.</param>
        public Subject(string name,
                       int rating,
                       string studentName,
                       string teacherName)
        {
            Rating = rating;
            Name = name;
            StudentName = studentName;
            TeacherName = teacherName;
        }

        /// <summary>
        /// Возвращает и задаёт значение оценки в промежутке от 0 до 100.
        /// </summary>
        public int Rating
        {
            get 
            { 
                return _rating; 
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 100, nameof(Rating));
                _rating = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задаёт наименование дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя студента.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string TeacherName { get; set; }
    }
}
