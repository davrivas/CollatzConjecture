using CollatzConjecture;
using System;

Console.WriteLine("Collatz conjecture");
Console.WriteLine();

for (int i = 1; i <= 1000; i++)
{
    var model = new Model(i);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Number: {0}", model.Number);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Number of steps: {0}", model.Steps.Count);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Steps: {0}", model.StepsStr);
    Console.ResetColor();
    Console.WriteLine();
}