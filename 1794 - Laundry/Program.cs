using System;

namespace _1794___Laundry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var lavarropa = Console.ReadLine().Split(' ');
            var secarropa = Console.ReadLine().Split(' ');

            int LA = int.Parse(lavarropa[0]);
            int LB = int.Parse(lavarropa[1]);

            int SA = int.Parse(secarropa[0]);
            int SB = int.Parse(secarropa[1]);

            if (n < LA || n > LB)
            {
                Console.WriteLine("impossivel");
                return;
            }

            if (n < SA || n > SB)
            {
                Console.WriteLine("impossivel");
                return;
            }

            Console.WriteLine("possivel");
        }
    }
}
