using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
            var queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                string mainCommand = command[0];
                string currentSong = SeparateSongFromCommand(command);

                switch (mainCommand)
                {
                    case "Play":
                        queue.Dequeue();
                        break;

                    case "Add":
                        if (!queue.Contains(currentSong))
                        {
                            queue.Enqueue(currentSong);
                        }
                        else
                        {
                            Console.WriteLine($"{currentSong} is already contained!");
                        }

                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));

                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("No more songs!");
        }

        private static string SeparateSongFromCommand(string[] command)
        {
            var songName = new List<string>();
            for (int j = 1; j < command.Length; j++)
            {
                songName.Add(command[j]);
            }
            string songToWork = string.Join(" ", songName);
            return songToWork;
        }
    }
}
