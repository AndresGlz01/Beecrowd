using System;

namespace _1067___Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            for(int i = 1; i <= value; i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
