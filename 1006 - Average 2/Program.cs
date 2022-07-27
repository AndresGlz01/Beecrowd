using System;

namespace _1006___Average_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            decimal result = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);
            System.Console.WriteLine($"MEDIA = {result:0.0}");
        }
    }
}
