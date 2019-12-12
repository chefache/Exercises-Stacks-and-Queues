using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            var queue = new Queue<string>();

            int peopleInCount = 0;

            while (names != "End")
            {
                if (names != "Paid")
                {
                    queue.Enqueue(names);
                    peopleInCount++;
                }
                    
                    if (names == "Paid")
                    {
                        for (int j = 0; j < peopleInCount; j++)
                        {
                            string currentName = queue.Dequeue();
                            Console.WriteLine(currentName);
                        }
                    }              
                names = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
