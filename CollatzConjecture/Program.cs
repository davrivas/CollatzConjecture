using System;

namespace CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz conjecture");
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int steps = Steps(num);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number of steps: " + steps);
            Console.ResetColor();
            Console.ReadKey();
        }

        static int Steps(int num)
        {
            int steps = 0;
            Console.WriteLine(num);

            while (num > 1)
            {
                num = num % 2 == 0
                    ? num / 2
                    : 3 * num + 1;

                steps++;
                Console.WriteLine(num);
            }

            return steps;
        }
    }
}
