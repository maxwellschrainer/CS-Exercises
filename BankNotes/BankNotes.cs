using System;

namespace Exercises
{
    public class Exercises
    {
        static void Main(string[] args)
        {
            int N, troco, n100, n50, n20, n10, n5, n2, n1;

            N = int.Parse(Console.ReadLine());

            n100 = N / 100;
            troco = N % 100;
            n50 = troco / 50;
            troco = troco % 50;
            n20 = troco / 20;
            troco = troco % 20;
            n10 = troco / 10;
            troco = troco % 10;
            n5 = troco / 5;
            troco = troco % 5;
            n2 = troco / 2;
            troco = troco % 2;
            n1 = troco / 1;
            troco = troco % 1;

            Console.WriteLine(N);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");
        }
    }
}