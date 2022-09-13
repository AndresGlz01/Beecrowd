using System;

namespace _1044___Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            double value1 = double.Parse(values[0]);
            double value2 = double.Parse(values[1]);

            if (value2 % value1 == 0 || value1 % value2 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
