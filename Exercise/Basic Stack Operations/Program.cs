using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandElements = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int numElemToPush = commandElements[0];
            int numElemToPop = commandElements[1];
            int searchedElem = commandElements[2];

            int[] elementsToPush = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(elementsToPush);

            for (int i = 0; i < numElemToPop; i++)
            {
                stack.Pop();
            }

            bool isContains = stack.Contains(searchedElem);

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (isContains)
            {
                Console.WriteLine("true");
            }
            if(stack.Count > 0 && isContains == false)
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
