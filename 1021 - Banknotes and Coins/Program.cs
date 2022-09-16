using System;

namespace _1021___Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = decimal.Parse(Console.ReadLine());

            System.Console.WriteLine("NOTAS:");
            var temp = (int)(value / 100);
            System.Console.WriteLine("{0:0} nota(s) de R$ 100.00", temp);
            value -= temp * 100;
            temp = (int)(value / 50);
            System.Console.WriteLine("{0} nota(s) de R$ 50.00", temp);
            value -= temp * 50;
            temp = (int)(value / 20);
            System.Console.WriteLine("{0} nota(s) de R$ 20.00", temp);
            value -= temp * 20;  
            temp = (int)(value / 10);         
            System.Console.WriteLine("{0} nota(s) de R$ 10.00", temp);
             value -= temp * 10;
            temp = (int)(value / 5);
            System.Console.WriteLine("{0} nota(s) de R$ 5.00", temp);
             value -= temp * 5;
            temp = (int)(value / 2);
            System.Console.WriteLine("{0} nota(s) de R$ 2.00", temp);
            value -= temp * 2;

            System.Console.WriteLine("MOEDAS:");
            temp = (int)(value / 1); 
            System.Console.WriteLine("{0} moeda(s) de R$ 1.00", temp);
            value -= temp * 1.00m;
            temp = (int)(value / 0.50m);
            System.Console.WriteLine("{0} moeda(s) de R$ 0.50", temp);
            value -= temp * 0.50m;
            temp = (int)(value / 0.25m);
            System.Console.WriteLine("{0} moeda(s) de R$ 0.25", temp);
            value -= temp * 0.25m;
            temp = (int)(value / 0.10m);
            System.Console.WriteLine("{0} moeda(s) de R$ 0.10", temp);
            value -= temp * 0.10m;
            temp = (int)(value / 0.05m);
            System.Console.WriteLine("{0} moeda(s) de R$ 0.05", temp);
            value -= temp * 0.05m;
            temp = (int)(value / 0.01m);
            System.Console.WriteLine("{0} moeda(s) de R$ 0.01", temp); 
            value -= temp * 0.01m;           
        }
    }
}
