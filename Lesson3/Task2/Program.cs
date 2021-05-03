using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of figure");
            var type = Console.ReadLine();
            if (type == "square")
            {
                Console.WriteLine("Write lenght of square");
                var squareLenght = int.Parse(Console.ReadLine());
                for (int i = 1; i <= squareLenght; i++)
                {
                    if (i == 1 || i == squareLenght)
                    {
                        for (int j = 1; j <= squareLenght; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 1; j <= squareLenght; j++)
                        {
                            if (j == 1 || j == squareLenght)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (type == "trapeze")
            {
                Console.WriteLine("Write two main lenght");
                var l1 = int.Parse(Console.ReadLine());
                var l2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Write height");
                var height = int.Parse(Console.ReadLine());

                for (int i = 0; i < height;  i++)
                {
                    for (int j = 1; j <= l1; j++)
                    {
                        Console.Write("*");
                    }
                    l1++;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
