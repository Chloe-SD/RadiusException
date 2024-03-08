using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace RadiusException
{
    internal class Circle
    {
        private double radius;

        public double GetRadius()
        {
            // getter for other class methods to access radius value
            return radius;
        }

        public Circle(double radius)
        {
            // CTOR overload
            //Creates the Object and then calls SetRadius
            Console.WriteLine($"Attempting to create new cirlce with radius of {radius}");
            this.SetRadius(radius);
        }

        public void SetRadius(double radius)
        {
            //Check if the radius is greater than zero
            if (radius > 0)
            {
                // If greater than zero, set it
                this.radius = radius;
                Console.WriteLine("Success, radius has been set.");
                Console.WriteLine(this);
            }
            else
            {
                // If equal or less than zero, throw exception
                new InvalidRadiusException(radius);
            }
        }
        public override string ToString()
        {
            // String override to display current circle information
            return $"This Circle has a radius of {this.radius}\n";
        }
        
    }
}
