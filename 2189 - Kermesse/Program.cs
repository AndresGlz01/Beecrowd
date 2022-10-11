using System;
using System.Collections.Generic;
using System.Linq;

namespace _2189___Kermesse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> winners = new List<int>();
            int cases = int.Parse(Console.ReadLine());
            while(cases != 0)
            {
                string[] participans = Console.ReadLine().Split();

                for (int i = 0; i < cases; i++)
                {
                    if(int.Parse(participans[i]) == i + 1)
                    {
                        winners.Add(int.Parse(participans[i]));
                    }
                }
                cases = int.Parse(Console.ReadLine());
            }

            int taste = 1;
            winners.ForEach(x => {
                System.Console.WriteLine("Taste {0}", taste++);
                System.Console.WriteLine(x);
                System.Console.WriteLine();
            });
        }
    }
}
