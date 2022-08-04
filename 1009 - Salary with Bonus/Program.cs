using System;

namespace _1009___Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sales = double.Parse(Console.ReadLine());

            double total = salary + (sales * 0.15);

            System.Console.WriteLine("TOTAL = R$ {0:f2}", total);
        }
    }
}
