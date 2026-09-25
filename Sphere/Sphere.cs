using System;
using System.Globalization;

namespace Exercises
{
    public class Sphere
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Lets calculate the volume of a sphere.");

            Console.WriteLine("Type the radius of the sphere: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4 / 3.0) * pi * Math.Pow(radius, 3);

            Console.WriteLine("The volume of the sphere is: " + volume.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}