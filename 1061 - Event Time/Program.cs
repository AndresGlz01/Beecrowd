using System;

namespace _1061___Event_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio = int.Parse(Console.ReadLine().Split(' ')[1]);
            string[] datosInicio = Console.ReadLine().Split(':');

            int horasInicio = int.Parse(datosInicio[0]);
            int minutosInicio = int.Parse(datosInicio[1]);
            int segundosInicio = int.Parse(datosInicio[2]);

            int diaFin = int.Parse(Console.ReadLine().Split(' ')[1]);
            string[] datosFin = Console.ReadLine().Split(" : ");

            int horasFin = int.Parse(datosFin[0]);
            int minutosFin = int.Parse(datosFin[1]);
            int segundosFin = int.Parse(datosFin[2]);

            int d = diaFin - diaInicio;
            int h = horasFin - horasInicio;
            int m = minutosFin - minutosInicio;
            int s = segundosFin - segundosInicio;

            if (s < 0)
            {
                s += 60;
                m--;
            }
            if (m < 0)
            {
                m += 60;
                h--;
            }
            if (h < 0)
            {
                h += 24;
                d--;
            }

            Console.WriteLine($"{d} dia(s)");
            Console.WriteLine($"{h} hora(s)");
            Console.WriteLine($"{m} minuto(s)");
            Console.WriteLine($"{s} segundo(s)");
        }
    }
}
