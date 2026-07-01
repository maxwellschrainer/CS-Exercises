using System;
using System.Transactions;

namespace Exercise
{
    internal class SimpleProduct 
    {
        static void Main(string[] args)
        {
            int n1, n2, PROD;

            Console.WriteLine("Welcome to the multiplier.");

            Console.WriteLine("");

            Console.WriteLine("Enter a number:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("One more:");
            n2 = int.Parse(Console.ReadLine());

            PROD = n1 * n2;

            Console.WriteLine("The multiplication of these two numbers is = " + PROD);
        }
    }
}