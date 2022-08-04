using System;

namespace _1005___Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());


            decimal result = (((number1 * 3.5m) + (number2 * 7.5m)) / (7.5m + 3.5m));

            System.Console.WriteLine($"MEDIA = {result:0.00000}");
        }
    }
}
