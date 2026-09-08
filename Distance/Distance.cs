using System;

namespace Exercises
{
    internal class Distance
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int tempo;
            tempo = distance * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}