using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine()
                .Split().Select(int.Parse));
            int inteligenceValue = int.Parse(Console.ReadLine());
            int bulletCounter = 0;

            while (bullets.Any() && locks.Any())
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bulletCounter++;
                if (bulletCounter % gunBarrelSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Count == 0)
            {
                int initialBulletsCount = bullets.Count;
                int spentForBullets = bulletCounter * bulletPrice;
                int result = inteligenceValue - spentForBullets;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${result}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
