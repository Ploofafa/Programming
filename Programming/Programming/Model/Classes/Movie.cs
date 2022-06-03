using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о фильме:
    /// наименование, год выпуска, рейтинг, длительность, жанр.
    /// </summary>
    public class Movie
    {

        /// <summary>
        /// Длительность. Должна быть положительным числом.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска. Должен лежать в промежутке от 1900 до текущего года.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг. Должен лежать в промежутке от 0 до 10.
        /// </summary>
        private double _rating;
        
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="year">Год выпуска. Должен лежать в промежутке от 1900 до текущего года.</param>
        /// <param name="duration">Длительность. Должна быть положительным числом.</param>
        /// <param name="rating">Рейтинг. Должен лежать в промежутке от 0 до 10.</param>
        private Movie(string title,
                      string genre,
                      int year,
                      int duration,
                      double rating)
        {
            Title = title;
            Year = year;
            Genre = genre;
            Rating = rating;
            Duration = duration;
        }

        /// <summary>
        /// Возвращает и задаёт длительность, должна быть положительной.
        /// </summary>
        public int Duration
        {
            get 
            { 
                return _duration; 
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// возвращает и задаёт год выпуска, должен лежать 
        /// в промежутке от 1900 до текущего года.
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }

            set 
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг. Должен лежать
        /// в промежутке от 0 до 10.
        /// </summary>
        public double Rating
        {
            get 
            { 
                return _rating; 
            }

            set 
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentOutOfRangeException("Rating can be in range [0, 10]");
                }
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }
        
    }
}
