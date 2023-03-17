using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о песне:
    /// номер в списке, длительность, альбом, название.
    /// </summary>
    public class Song
    {

        /// <summary>
        /// Номер в списке. Должен быть положительным целым числом.
        /// </summary>
        private int _id;

        /// <summary>
        /// Длительность. Должна быть положительным числом.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="id">Номер в списке. Должен быть положительным целым числом.</param>
        /// <param name="duration">Длительность. Должна быть положительным числом.</param>
        /// <param name="album">Наименование альбома.</param>
        /// <param name="name">Наименование песни.</param>
        public Song(int id,
                    int duration,
                    string album,
                    string name)
        {
            Duration = duration;
            Id = id;
            Album = album;
            Name = name;
        }

        /// <summary>
        /// Возвращает и задаёт номер песни в списке.
        /// Должно быть положительным числом.
        /// </summary>
        public int Id
        {
            get 
            { 
                return _id; 
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Id));
                _id = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт длительность песни.
        /// Должна быть больше нуля.
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
        /// Возвращает и задаёт альбом.
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя песни.
        /// </summary>
        public string Name { get; set; }
    }
}
