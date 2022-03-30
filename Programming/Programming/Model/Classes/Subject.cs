using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _rating;
        private string _name;
        private string _nameStudent;
        private string _nameTeacher;

        public Subject() 
        {
        }

        public Subject MakeSubject(string name,
                                int rating,
                                string nameStudent,
                                string nameTeacher)
        {
            Subject subject = new Subject();
            _rating = rating;
            _name = name;
            _nameStudent = nameStudent;
            _nameTeacher = nameTeacher;
            return subject;
        }
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value <= 0 | value > 100)
                {
                    throw new ArgumentException("Rating can't be > 100 and < 0");
                }
                _rating = value;
            }
        }
        public string Name { get; set; }
        public string NameStudent { get; set; } 
        public string NameTeacher { get; set; }

    }
}
