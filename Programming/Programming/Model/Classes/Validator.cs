using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static int AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{name} must be positive number");
            }
            return value;
        }

        public static double AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{name} must be positive number");
            }
            return value;
        }

        public static int AssertValueInRange(int value, int min, int max, string name)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"{name} must be in range [{min}, {max}]");
            }
            return value;
        }
    }
}
