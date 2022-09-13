using System;

namespace _1019___Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());

            System.Console.Write($"{seconds / 3600}:");
            seconds -= (seconds / 3600) * 3600;

            System.Console.Write($"{seconds / 60}:");
            seconds -= (seconds / 60) * 60;

            System.Console.Write($"{seconds}");
            System.Console.WriteLine();
        }
    }
}
