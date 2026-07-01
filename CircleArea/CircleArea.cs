using System.Globalization;

namespace Exercises
{
    internal class CircleArea
    {
        static void Main(string[] args)
        {
            double A, R, pi;

            pi = 3.14159;

            Console.WriteLine("Welcome to the circle area calculator.");

            Console.WriteLine("Enter the radius of your circle: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("The area of your circle is = " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}