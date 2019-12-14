using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandElements = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int numElemToEnque = commandElements[0];
            int numElemToDeque = commandElements[1];
            int searchedElem = commandElements[2];

            int[] elementsToEnque = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(elementsToEnque);

            for (int i = 0; i < numElemToDeque; i++)
            {
                queue.Dequeue();
            }

            bool isContains = queue.Contains(searchedElem);

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (isContains)
            {
                Console.WriteLine("true");
            }
            if (queue.Count > 0 && isContains == false)
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
