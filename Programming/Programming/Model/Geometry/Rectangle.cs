using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private int _height;

        private int _width;

        private static int _allRectanglesCount;

        private int _rectangleId;

        public Rectangle()
        {
            _allRectanglesCount++;
            _rectangleId = _allRectanglesCount;
        }

        public Rectangle(int height,
                         int width,
                         string color,
                         Point2D point)
        {
            Height = height;
            Width = width;
            Color = color;
            Centre = point;
            _allRectanglesCount++;
            _rectangleId = _allRectanglesCount;
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        public int Width
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
