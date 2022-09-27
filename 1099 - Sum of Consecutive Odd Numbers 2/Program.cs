using System;

namespace _1099___Sum_of_Consecutive_Odd_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int[] results = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int sum = 0;

                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);

                if (x > y)
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }
                else
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }

                results[i] = sum;
            }

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
