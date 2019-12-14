using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
           
            Stack<int> clothesInRack = new Stack<int>(box);
          
            int capacity = int.Parse(Console.ReadLine());
         
            int sum = 0;
          
            int numberOfRacks = 1;

            while (clothesInRack.Count > 0)
            {
                sum += clothesInRack.Peek();
               
                if (sum <= capacity)
                {
                    clothesInRack.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }

            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
