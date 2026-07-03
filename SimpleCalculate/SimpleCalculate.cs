using System;
using System.Globalization;

namespace Exercises
{
    internal class SimpleCalculate
    {
        static void Main(string[] args)
        {
            double product1, product2, calc;

            Console.WriteLine("Let's calculate how much you would pay for two products.");

            Console.WriteLine("");

            Console.WriteLine("First, enter the product code, how many units do you want to buy and the unit price, in the same line separated by a blank space.");

            string[] vet1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(vet1[0]);
            int unit1 = int.Parse(vet1[1]);
            double price1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("OK, do it again for the second product.");

            string[] vet2 = Console.ReadLine().Split(' ');
            int code2 = int.Parse (vet2[0]);
            int unit2 = int.Parse (vet2[1]);
            double price2 = double.Parse (vet2[2], CultureInfo.InvariantCulture);

            product1 = unit1 * price1;
            product2 = unit2 * price2;
            calc = product1 + product2;

            Console.WriteLine("You'll have to pay = U$ " + calc.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}