using System;

namespace _1064___Positives_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[6];
            int positives = 0;
            double average = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 0)
                {
                    positives++;
                    average += numbers[i];
                }
            }  

            System.Console.WriteLine("{0} valores positivos", positives);   
            System.Console.WriteLine($"{(average / positives):0.0}");   
        }
    }
}
