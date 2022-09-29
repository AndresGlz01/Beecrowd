using System;
using System.Numerics;

namespace _1593___Binary_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            int[] results = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                BigInteger value = BigInteger.Parse(Console.ReadLine());
                string binary = ToBinary(value);
                int sum = 0;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        sum++;
                    }
                }
                results[i] = sum;
            }

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
        public static string ToBinary(BigInteger number)
        {
            BigInteger remainder;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }
    }
}
