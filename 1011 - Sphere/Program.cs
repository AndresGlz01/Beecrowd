using System;

namespace _1011___Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            int rad = int.Parse(Console.ReadLine());
            double result = (4d / 3d) * 3.14159d * Math.Pow(rad, 3);
            System.Console.WriteLine("VOLUME = {0:0.000}", result);
        }
    }
}
