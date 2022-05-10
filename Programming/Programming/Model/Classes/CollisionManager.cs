using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        
        public static bool IsCollision(Model.Classes.Rectangle rectangle1,
                                Model.Classes.Rectangle rectangle2)
        {
            int dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
            int dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);
            double width = rectangle1.Width + rectangle2.Width;
            double height = rectangle1.Height + rectangle2.Height;
            return rectangle1.Centre.X < rectangle2.Centre.X + rectangle2.Width &&
                rectangle1.Centre.X + rectangle1.Width < rectangle2.Centre.X &&
                rectangle1.Centre.Y < rectangle2.Centre.Y + rectangle2.Height &&
                rectangle1.Height + rectangle1.Centre.Y > rectangle2.Centre.Y;

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
