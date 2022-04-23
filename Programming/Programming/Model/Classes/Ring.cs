using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        private double _area;

        public Ring()
        {
        }

        public Ring(int outerRadius,
                    int innerRadius,
                    Point2D point)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = point;
        }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (_outerRadius < _innerRadius)
                {
                    throw new ArgumentException("Outer radius can't be less than inner radius");
                }
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (_innerRadius > _outerRadius)
                {
                    throw new ArgumentException("Inner radius can't be more then outer radius");
                }
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                _area = Math.Pow(this.OuterRadius, 2) * Math.PI - Math.Pow(this.InnerRadius, 2) * Math.PI;
                Validator.AssertOnPositiveValue(_area, nameof(Area));
                return _area;
            }
        }

        public Point2D Centre { get; set; }
    }
}
