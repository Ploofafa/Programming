using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movies
    {
        private int _duration;
        private int _year;
        private double _rating;
        private string _title;
        private string _genre;
        
        public Movies()
        {
        }
        Movies MakeMovie(string title,
                        string genre,
                        int year,
                        int duration,
                        double rating)
        {
            Movies movie = new Movies();
            _title = title;
            _year = year;
            _genre = genre;
            _rating = rating;
            _duration = duration;
            return movie;
        }
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration can't ");
                }
                _duration = value;
            }
        }
        public int Year
        {
            set 
            {
                if (value < 1900 | value > 2023)
                {
                    throw new ArgumentException("Year can be only > 1900");
                }
                _year = value;
            }
            get { return _year; }
        }
        public double Rating
        {
            get { return _rating; }
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
