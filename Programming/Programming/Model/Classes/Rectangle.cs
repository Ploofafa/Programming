using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangles
    {
        private double _length;
        private double _width;
        private string _color;
        public Rectangles()
        {
        }
        public Rectangles MakeRectangle(double length,
                                    double width,
                                    string color)
        {
            Rectangles rectangle = new Rectangles();
            _length = length;
            _width = width;
            _color = color;
            return rectangle;
        }
        public double Length
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rectangle length must be > 0");
                }
                _length = value;
            }
            get
            {
                return _length;
            }
        }
        public double Width
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rectangle width must be > 0");
                }
                _width = value;
            }
            get { return _width; }
        }
        public string Color { get; set; }
    }
}
