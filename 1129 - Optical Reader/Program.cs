using System;
using System.Collections.Generic;

namespace _1129___Optical_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<string> results = new List<string>();
            while (cases != 0)
            {
                for (int j = 0; j < cases; j++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');

                    int A = int.Parse(inputs[0]);
                    int B = int.Parse(inputs[1]);
                    int C = int.Parse(inputs[2]);
                    int D = int.Parse(inputs[3]);
                    int E = int.Parse(inputs[4]);
                    if (A <= 127 && A != B && A != C && A != D && A != E && 127 < B && 127 < C && 127 < D && 127 < E)
                    {
                        results.Add("A");
                    }
                    else if (B <= 127 && B != A && B != C && B != D && B != E && 127 < A && 127 < C && 127 < D && 127 < E)
                    {
                        results.Add("B");
                    }
                    else if (C <= 127 && C != B && C != A && C != D && C != E && 127 < B && 127 < A && 127 < D && 127 < E)
                    {
                        results.Add("C");
                    }
                    else if (D <= 127 && D != B && D != C && D != A && D != E && 127 < B && 127 < C && 127 < A && 127 < E)
                    {
                        results.Add("D");
                    }
                    else if (E <= 127 && E != B && E != C && E != D && E != A && 127 < B && 127 < C && 127 < D && 127 < A)
                    {
                        results.Add("E");
                    }
                    else
                    {
                        results.Add("*");
                    }                    
                }
                cases = int.Parse(Console.ReadLine());
            }
            results.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
