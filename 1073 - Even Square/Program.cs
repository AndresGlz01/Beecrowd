using System;

namespace _1073___Even_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine("{0}^2 = {1}", i, i * i);
                }
            }
        }
    }
}
