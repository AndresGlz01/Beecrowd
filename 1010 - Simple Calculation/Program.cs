using System;

namespace _1010___Simple_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product1 = Console.ReadLine().Split(' ');
            string[] product2 = Console.ReadLine().Split(' ');

            decimal totalProduct1 = decimal.Parse(product1[1]) * decimal.Parse(product1[2]);
            decimal totalProduct2 = decimal.Parse(product2[1]) * decimal.Parse(product2[2]);

            decimal total = totalProduct1 + totalProduct2;

            System.Console.WriteLine("VALOR A PAGAR: R$ {0}", total);
        }
    }
}
