using System;

namespace _1075___Remaining_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % number == 2)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
