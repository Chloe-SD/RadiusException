/*
 

Chloe Nibali - 000913397
CPRG 211 E - OOP 2
Lab 5 - Creating Exceptions
Mar 8, 2024
 
 
 
 */





namespace RadiusException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test program by creating 3 circle objects

            // A circle with a positive radius
            Console.WriteLine("Test case 1: Positive radius");
            Circle c1 = new Circle(1.4);

            // with a negative radius
            Console.WriteLine("Test case 2: Negative Radius");
            Circle c2 = new Circle(-5);

            // with a ZERO radius
            Console.WriteLine("Test case 3: radius of zero");
            Circle c3 = new Circle(0);
        }
    }
}
