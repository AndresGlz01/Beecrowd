using System;

namespace _1013___The_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
            int s = int.Parse(values[2]);

            int result = Compare(Compare(a, b), s);

            System.Console.WriteLine("{0} eh o maior", result);
        }
        static int Compare(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }
    }
}
