using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxAttemp = 5;

            for (int i = 0; i < maxAttemp; i++)
            {
                Console.WriteLine("Mystery");
                var answer = Console.ReadLine();

                if (answer != "YES" && answer != "yes" && answer != "Yes")
                {
                    Console.WriteLine("Incorrect give more money to try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("YOU WIN!!! TAKE MONEY");
                    Console.WriteLine("END GAME");
                    return;
                }
            }
            Console.WriteLine("You LOSE");
            Console.WriteLine("END GAME");
        }
    }
}