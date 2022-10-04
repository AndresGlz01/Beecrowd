using System;
using System.Collections.Generic;
using System.Linq;

namespace _1171___Number_Frequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            List<int> distincNumbers = (from num in numbers select num).Distinct().OrderBy(x => x).ToList();

            distincNumbers.ForEach(x =>
            {
                int count = numbers.Where(temp => temp.Equals(x)).Select(temp => temp).Count();
                Console.WriteLine("{0} aparece {1} vez(es)", x, count);
            });
        }
    }
}
