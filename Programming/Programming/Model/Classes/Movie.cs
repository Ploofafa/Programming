using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;

        private int _year;

        private double _rating;
        
        public Movie()
        {
        }

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

        public string Title { get; set; }

        public string Genre { get; set; }
        
    }
}
