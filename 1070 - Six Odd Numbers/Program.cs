using System;

namespace _1070___Six_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count;

            for(count = 1; count <= 6; number++)
            {
                if(number % 2 != 0)
                {
                    Console.WriteLine(number);
                    count++;
                }
            }
        }
    }
}
