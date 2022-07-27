using System;

namespace _1007___Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int result = (a * b) - (c * d);
            System.Console.WriteLine($"DIFERENCA = {result}");
        }
    }
}
