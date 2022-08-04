using System;

namespace _1008___Salary
{
    class Program
    {
        static void Main(string[] args)
        {
           int empleoyeeNum = int.Parse(Console.ReadLine());
           int hoursWorked = int.Parse(Console.ReadLine());
           decimal amoutHour = decimal.Parse(Console.ReadLine());

           System.Console.WriteLine("NUMBER = {0}", empleoyeeNum);
           System.Console.WriteLine("SALARY = U$ {0:0.00}", hoursWorked * amoutHour);
        }
    }
}
