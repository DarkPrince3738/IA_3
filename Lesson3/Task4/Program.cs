using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write how many numbers has your number");
            var answer = int.Parse(Console.ReadLine());
            int k = 1;

            for(int i = 1; i <= answer; i++)
            {
                k *= 10;
            }
            Console.WriteLine($"You have {k} variants");
        }
    }
}
