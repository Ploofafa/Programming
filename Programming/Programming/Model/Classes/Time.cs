using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public Time()
        {
        }
        public Time MakeTime(int hour,
                            int minute,
                            int second)
        {
            Time time = new Time();
            Hour = hour;
            Minute = minute;
            Second = second;
            return time;
        }
        public int Hour
        {
            set
            {
                if (value < 0 | value > 23)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
            }
            get { return _hour; }

        }
        public int Minute
        {
            set
            {
                if(value < 0 | value > 60)
                {
                    throw new ArgumentException("");
                }
                _minute = value;
            }
            get { return _minute; }
        }
        public int Second
        {
            set
            {
                if (value > 0 | value > 60)
                {
                    throw new ArgumentException("");
                }
                _second = value;
            }
            get { return _second; }
        }
    }
}
