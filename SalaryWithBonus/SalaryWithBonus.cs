using System;
using System.Globalization;

namespace exercises 
{ 
    internal class SalaryWithBonus
    {
        static void Main(string[] args)
        {
            string name;
            double salary, salesvalue, salestotal, total;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salesvalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 0.15;
            salestotal = salesvalue ;
            total = salestotal + salary;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}