using System;
using System.Collections.Generic;

namespace _1387___Og
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int r = 0;
            List<int> results = new List<int>();

            do
            {
                string[] values = Console.ReadLine().Split(' ');

                l = int.Parse(values[0]);
                r = int.Parse(values[1]);

                if(l == 0 && r == 0)
                {
                    break;
                }

                results.Add(l + r);

            } while (l != 0 && r != 0);

            results.ForEach(x => System.Console.WriteLine(x));
        }
    }
}
