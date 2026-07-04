using System;
using System.Globalization;

namespace Exercises
{
    internal class Consumption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the km consumption your car made");

            Console.WriteLine("");

            Console.WriteLine("First, how much km have you done in the last travel?");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("How much fuel was spent in total?");
            float y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float kml = X / y;

            Console.WriteLine("Your car have done: " + kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}