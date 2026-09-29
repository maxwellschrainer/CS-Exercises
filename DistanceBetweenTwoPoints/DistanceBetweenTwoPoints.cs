using System;
using System.Globalization;

namespace Exercises
{
    public class DistanceBetweenTwoPoints
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distance;

            string[] valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}