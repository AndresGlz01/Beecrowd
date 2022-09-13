using System;

namespace _1017___Spent_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int duration = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());

            double distance = duration * speed;
            double result = distance / 12;

            System.Console.WriteLine(result.ToString("0.000"));
        }
    }
}
