using System;
using System.Globalization;

namespace exercises 
{ 
    internal class SalaryWithBonus
    {
        static void Main(string[] args)
        {
            string name;
            double salary, salesvalue, total;

            Console.WriteLine("Type your name:");
            name = Console.ReadLine();

            Console.WriteLine("Type your salary:");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Type the value from all your sales:");
            salesvalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 0.15;

            total = salesvalue + salary;

            Console.WriteLine(name + ", doing the sum from the 15% of your sales, plus your salary, you will receive: $ " + total.ToString("F2", CultureInfo.InvariantCulture) + " this month.");
            Console.ReadLine();
        }
    }
}