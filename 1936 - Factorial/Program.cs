using System;

namespace _1936___Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = 0;
            int f = 0;

            for (int i = 8; i >= 0; --i)
            {
                f = fat(i);
                temp = number / f;
                number -= temp * f;
                count += temp;
            }

            Console.WriteLine(count);
        }

        static int fat(int n)
        {
            if (n <= 1) return 1;
            else return n * fat(n - 1);
        }
    }
}
