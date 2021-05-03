using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write two numbers");

                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());

                if (n1 == n2)
                {
                    Console.WriteLine("n1=n2, try again");
                    Console.WriteLine("");
                    continue;
                }
                else if (n1 > n2)
                {
                    for (int i = n2 + 1; i < n1; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
                else
                {
                    for (int i = n1 + 1; i < n2; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
            }
        }
    }
}