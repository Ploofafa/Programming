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

        public Subject() 
        {
        }

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
        
        public string Name { get; set; }
        
        public string StudentName { get; set; } 
        
        public string TeacherName { get; set; }
    }
}
