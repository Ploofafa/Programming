using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    static class RectangleFactory
    {
        static Random random = new Random();
        public static Rectangle Randomize()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = random.Next(1, 150);
            rectangle.Height = random.Next(1, 150);
            rectangle.Centre = new Point2D(random.Next(0, 990), random.Next(0, 530));          
            return rectangle;
        }
    }
}
