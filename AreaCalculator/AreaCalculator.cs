using System.Globalization;

namespace Exercises
{
    internal class AreaCalculator
    {
        static void Main(string[] args)
        {
            double width, lenght, squareMeterPrice, area, price;

            Console.WriteLine("Welcome to the area calculator.");

            Console.WriteLine("Enter the width of your area.");
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Now, enter the lenght of your area.");
            lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Finally, enter the price per square meter.");
            squareMeterPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = width * lenght;
            price = squareMeterPrice * area;

            Console.WriteLine("Your area is = " + area.ToString("F2", CultureInfo.InvariantCulture) + " and the price will be = " + price.ToString("F2", CultureInfo.InvariantCulture) + ".");
        }
    }
}