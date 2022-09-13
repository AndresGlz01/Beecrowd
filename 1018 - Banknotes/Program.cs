using System;

namespace _1018___Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine(value);

            System.Console.WriteLine("{0} nota(s) de R$ 100,00", value / 100);
            value -= 100 * (value / 100);
            System.Console.WriteLine("{0} nota(s) de R$ 50,00", value / 50);
            value -= 50 * (value / 50);
            System.Console.WriteLine("{0} nota(s) de R$ 20,00", value / 20);
            value -= 20 * (value / 20);
            System.Console.WriteLine("{0} nota(s) de R$ 10,00", value / 10);
            value -= 10 * (value / 10);
            System.Console.WriteLine("{0} nota(s) de R$ 5,00", value / 5);
            value -= 5 * (value / 5);
            System.Console.WriteLine("{0} nota(s) de R$ 2,00", value / 2);
            value -= 2 * (value / 2);
            System.Console.WriteLine("{0} nota(s) de R$ 1,00", value / 1);
        }
    }
}
