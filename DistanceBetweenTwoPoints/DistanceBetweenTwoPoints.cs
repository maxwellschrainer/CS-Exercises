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

            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt((x2 - x1) * 2) + ((y2 - y1) * 2);

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}