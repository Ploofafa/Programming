using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Хранит переменную с желаемой датой доставки.
        /// </summary>
        private DateTime _desiredDate;

        /// <summary>
        /// Хранит все диапазоны значений времени доставки.
        /// </summary>
        private string[] _rangeTime= new string[]
            {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
            };

        /// <summary>
        /// Хранит переменную с желаемым временем доставки.
        /// </summary>
        private string _desiredTime;

        public string[] RangeTime
        {
            get
            {
                return _rangeTime;
            }
        }

        public DateTime DesiredDate
        {
            get
            {
                return _desiredDate;
            }
            set
            {

                _desiredDate = value;
            }
        }

        public string DesiredTime
        {
            get
            {
                return _desiredTime;
            }
            set
            {
                _desiredTime = value;
            }
        }

        public PriorityOrder()
        {
        }

        public PriorityOrder( DateTime desiredTime, DateTime desiredDate) : base()
        {
            _desiredDate = DesiredDate;
            _desiredTime = DesiredTime;
        }
    }
}
