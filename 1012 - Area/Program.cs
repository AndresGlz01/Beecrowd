using System;

namespace _1012___Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');

            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            double triangulo = (A * C) / 2d;
            double circulo = 3.14159d * Math.Pow(C, 2);
            double trapecio = ((A + B) * C) / 2d;
            double cuadrado = Math.Pow(B, 2);
            double rectangulo = A * B;

            System.Console.WriteLine("TRIANGULO: {0:0.000}\nCIRCULO: {1:0.000}\nTRAPEZIO: {2:0.000}\nQUADRADO: {3:0.000}\nRETANGULO: {4:0.000}", triangulo, circulo, trapecio, cuadrado, rectangulo);
        }
    }
}
