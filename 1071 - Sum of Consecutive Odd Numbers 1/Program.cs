using System;

namespace _1071___Sum_of_Consecutive_Odd_Numbers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;
            if(x > y)
            {
                for(int i = y + 1; i < x; i++)
                {
                    if(i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                System.Console.WriteLine(sum);
            }
            else if(y > x)
            {
                for(int i = x + 1; i < y; i++)
                {
                    if(i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                System.Console.WriteLine(sum);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }
    }
}
