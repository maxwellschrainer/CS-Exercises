using System;
using System.Globalization;

#region Exercise explanation

//a) the area of the rectangled triangle that has base A and height C.
//b) the area of the radius's circle C. (pi = 3.14159)
//c) the area of the trapezium which has A and B by base, and C by height.
//d) the area of ​​the square that has side B.
//e) the area of the rectangle that has sides A and B.

//Input
//The input file contains three double values with one digit after the decimal point.

#endregion

namespace Exercises
{
    public class Area
    {
        static void Main(string[] args)
        {
            float A, B, C;
            double a, b, c, d, e;
            double pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            C = float.Parse(vet[2], CultureInfo.InvariantCulture);

            a = (1 / 2.0) * A * C;
            b = (C * C) * pi;
            c = ((A + B) / 2) * C;
            d = B * B;
            e = A * B;

            Console.WriteLine("TRIANGULO: " + a.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + b.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + c.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + d.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + e.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}