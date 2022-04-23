using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        private static int _allRectanglesCount;

        private int _rectangleId;

        public Rectangle()
        {
            _allRectanglesCount++;
            _rectangleId = _allRectanglesCount;
        }

        public Rectangle(double length,
                         double width,
                         string color,
                         Point2D point)
        {
            Length = length;
            Width = width;
            Color = color;
            Centre = point;
            _allRectanglesCount++;
            _rectangleId = _allRectanglesCount;
        }

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public static int AllRectanglesCount
        {
            get
            {
                return AllRectanglesCount;
            }
        }

        public int RectangleId
        {
            get
            {
                return _rectangleId;
            }
        }

        public string Color { get; set; }

        public Point2D Centre { get; set; }
        
    }
}
