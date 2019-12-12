using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "add")
                {
                    stack.Push(int.Parse(commandArgs[1]));
                    stack.Push(int.Parse(commandArgs[2]));
                }
                if (mainCommand == "remove")
                {
                    int itemsToRemove = int.Parse(commandArgs[1]);
                    if (stack.Count > itemsToRemove)
                    {
                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }                  
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
