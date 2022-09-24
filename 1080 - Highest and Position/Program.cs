using System;

namespace _1080___Highest_and_Position
{
    class Program
    {
        static void Main(string[] args)
        {
		int[] numbers = new int[100];
		int biggestNumber = 0;
		int biggestNumberPosition = 0;
		
		for(int i = 0; i <= 99; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
			if(numbers[i] > biggestNumber)
			{
				biggestNumber = numbers[i];
				biggestNumberPosition = i;
			}
		}
		
		
		Console.WriteLine(biggestNumber);
		Console.WriteLine(biggestNumberPosition + 1);
        }
    }
}
