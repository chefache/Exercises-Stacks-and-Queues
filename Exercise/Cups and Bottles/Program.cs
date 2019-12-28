using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var bottlesInfo = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            var cups = new Queue<int>(cupsInfo);
            var bottles = new Stack<int>(bottlesInfo);

            int wastedWater = 0;


            int cup = cups.Peek();
            while (cups.Any() && bottles.Any()) 
            {
                
                int bottle = bottles.Pop();
                
                if (bottle >= cup)
                {
                    bottle -= cup;
                    wastedWater += bottle;

                    cups.Dequeue();

                    if (cups.Count > 0)
                    {
                        cup = cups.Peek();
                    }
                }
                else
                {
                    cup -= bottle;
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
