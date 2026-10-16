using System;
using System.Net.NetworkInformation;

namespace Exercises
{
    public class Exercises
    {
        // enter a number of days and the program will calculate how old are you in years, months and days.
        static void Main(string[] args)
        {
            int A, resto, anos, meses, dias;

            A = int.Parse(Console.ReadLine());

            anos = A / 365;
            resto = A % 365;
            meses = resto / 30;
            resto = resto % 30;
            dias = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " anos(s)");
            Console.WriteLine(meses + " mes(s)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}