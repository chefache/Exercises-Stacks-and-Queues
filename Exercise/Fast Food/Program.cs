using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var foodTotalSum = 0;

            while (true)
            {
                int[] orders = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < orders.Length; i++)
                {
                    queue.Enqueue(orders[i]);
                    foodTotalSum += orders[i];
                }
                Console.WriteLine(queue.Max());

                if (foodTotalSum <= foodQuantity)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }

                for (int i = 0; i < foodQuantity; i++)
                {
                    foodQuantity -= queue.Peek();
                    
                    if (foodQuantity <= 0)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                            return;
                        }                       
                    }
                    queue.Dequeue();
                }            
            }
        }
    }
}
