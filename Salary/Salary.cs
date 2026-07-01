using System;
using System.Globalization;

namespace Exercises
{
    internal class Salary
    {
        static void Main(string[] args)
        {
            int hours;
            double hourAmount, salary;

            Console.WriteLine("Let's calculate your salary based on your hours worked and amount per hour.");

            Console.WriteLine("");

            Console.WriteLine("How much hours do you work in a month?");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("How much do you earn per hour?");
            hourAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hours * hourAmount;

            Console.WriteLine("Your salary is = " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}