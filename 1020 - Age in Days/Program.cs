using System;

namespace _1020___Age_in_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"{age / 365} ano(s)");
            age -= (age / 365) * 365;

            System.Console.WriteLine($"{age / 30} mes(es)");
            age -= (age / 30) * 30;

            System.Console.WriteLine($"{age} dia(s)");
        }
    }
}
