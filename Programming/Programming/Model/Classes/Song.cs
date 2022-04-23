using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _id;

        private int _duration;

        public Song()
        {
        }

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

        public string Album { get; set; }

        public string Name { get; set; }
    }
}
