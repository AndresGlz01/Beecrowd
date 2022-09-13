using System;
using System.Collections.Generic;
using System.Linq;

namespace _1042___Simple_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();

            numbers.Add(int.Parse(values[0]));
            numbers.Add(int.Parse(values[1]));
            numbers.Add(int.Parse(values[2]));

            (from num in numbers orderby num select num).ToList().ForEach(
                x => Console.WriteLine(x));

            Console.WriteLine();

            numbers.ForEach(x => Console.WriteLine(x));
        }
    }
}
