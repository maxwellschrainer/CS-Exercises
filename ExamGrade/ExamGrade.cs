using System.Globalization;

namespace Exercises 
{
    public class Exercises 
    { 
        static void Main(string[] args) 
        {
            double grade1, grade2, finalgrade;

            grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            finalgrade = grade1 + grade2;

            Console.WriteLine("NOTA FINAL = " + finalgrade.ToString("F1", CultureInfo.InvariantCulture));

            if (finalgrade < 60.00)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}