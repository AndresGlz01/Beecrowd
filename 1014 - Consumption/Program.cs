using System;

namespace _1014___Consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double result = x / y;

            System.Console.WriteLine("{0:0.000} km/l", result);
        }
    }
}
