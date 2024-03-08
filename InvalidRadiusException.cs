using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusException
{
    internal class InvalidRadiusException
    {
        public InvalidRadiusException()
        {
            Console.WriteLine("Error: radius is LESS THAN or EQUAL to ZERO\n");
        }
        public InvalidRadiusException(double radius)
        {
            Console.WriteLine($"{radius} is not a valid value for radius\n");
        }
    }
}
