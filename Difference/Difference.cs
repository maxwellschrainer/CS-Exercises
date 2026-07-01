using System;

namespace Exercises 
{
    internal class Difference
    {
        static void Main(string[] args) 
        {
            int A, B, C, D, difference;

            Console.WriteLine("Welcome to the difference calculator");

            Console.WriteLine("");

            Console.WriteLine("Enter a number:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Another:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("And another:");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("One more:");
            D = int.Parse(Console.ReadLine());

            difference = A * B - C * D;

            Console.WriteLine("The difference of these numbers are = " + difference);
        }
    }
}