using System;

namespace _1116___Dividing_X_by_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] results = new string[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                double x = int.Parse(values[0]);
                double y = int.Parse(values[1]);

                if (y == 0)
                {
                    results[i] = "divisao impossivel";
                }
                else
                {
                    results[i] = (x / y).ToString("0.0");
                }
            }

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
