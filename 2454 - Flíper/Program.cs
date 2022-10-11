using System;

namespace _2454___Flíper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();

            int P = int.Parse(values[0]);
            int R = int.Parse(values[1]);

            if (P == 0)
            {
                System.Console.WriteLine("C");
                return;
            }

            if (R == 0)
            {
                System.Console.WriteLine("B");
                return;
            }

            System.Console.WriteLine("A");
        }
    }
}
