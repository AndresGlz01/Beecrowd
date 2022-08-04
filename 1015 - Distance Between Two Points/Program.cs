using System;

namespace _1015___Distance_Between_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var values1 = Console.ReadLine().Split(' ');
            var values2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(values1[0]); 
            double y1 = double.Parse(values1[1]);
            double x2 = double.Parse(values2[0]);
            double y2 = double.Parse(values2[1]);

            double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            System.Console.WriteLine(result.ToString("0.0000"));
        }
    }
}
