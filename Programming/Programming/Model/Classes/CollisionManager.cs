using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1,
                                Rectangle rectangle2)
        {
            double dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
            double dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);
            double width = Math.Abs(rectangle1.Width - rectangle2.Width) / 2;
            double length = Math.Abs(rectangle1.Length - rectangle2.Length) / 2;

            if ((dx < width) & (dy < length))
            {
                return true;
            }
            return false;
        }

        public static bool IsCollision(Ring ring1,
                                Ring ring2)
        {
            double dx = Math.Abs(ring1.Centre.X - ring2.Centre.X);
            double dy = Math.Abs(ring1.Centre.Y - ring2.Centre.Y);
            double C = dx * dx + dy * dy;

            if (C < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }            
            return false;
        }
    }
}
