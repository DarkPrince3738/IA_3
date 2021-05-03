using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int try_ = 5;
            for (int i = 0; i < try_; i++)
            {
                Console.WriteLine("Write the number from 1-100");
                int answer = int.Parse(Console.ReadLine());
                if ((answer >= 1 && answer <= 10) || (answer >= 15 && answer <= 25) || (answer >= 30 && answer <= 70) || (answer >= 75 && answer <= 98) || (answer == 100))
                {
                    Console.WriteLine("Got You");
                }
                else
                {
                    Console.WriteLine("You're in safe");
                    Console.WriteLine("End Game");
                    return;
                }
            }
                Console.WriteLine("You Lose");
        }
    }
}
