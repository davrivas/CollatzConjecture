using System;
using System.Collections.Generic;
using System.Linq;

namespace CollatzConjecture
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz conjecture");
            Console.WriteLine();

            for (int i = 1; i <= 1000; i++)
            {
                var model = GetModel(i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Number: {0}", model.Number);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Number of steps: {0}", model.Steps.Count());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Steps: {0}", model.StepsStr);
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static Model GetModel(int num)
        {
            var model = new Model
            {
                Number = num,
                Steps = Enumerable.Empty<int>()
            };

            while (num > 1)
            {
                num = num % 2 == 0
                    ? num / 2
                    : 3 * num + 1;
                model.Steps = model.Steps.Append(num);
            }

            return model;
        }
    }

    internal class Model
    {
        public int Number { get; set; }
        public IEnumerable<int> Steps { get; set; }
        public string StepsStr => string.Join(", ", Steps);
    }
}
