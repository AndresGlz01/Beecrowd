using System;

namespace _1035___Selection_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
            int c = int.Parse(values[2]);
            int d = int.Parse(values[3]);

            if(b > c & d > a & (c + d) > (a + b) & c > 0 & d > 0 & a % 2 == 0)
            {
                System.Console.WriteLine("Valores aceitos");
            }
            else
            {
                System.Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
