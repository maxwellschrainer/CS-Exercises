using System;

namespace Exercises
{
    internal class SimpleSum
    {
        static void Main(string[] args)
        {
            int A, B, SUM;

            Console.WriteLine("Welcome to the addition calculator.");

            Console.WriteLine("");

            Console.WriteLine("Enter a number:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("One more:");
            B = int.Parse(Console.ReadLine());

            SUM = A + B;

            Console.WriteLine("The sum of these two numbers is = " + SUM);
        }
    }
}