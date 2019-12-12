using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            Stack<char> characters = new Stack<char>(text);
            bool isExist = characters.Contains('a');
           
            while (characters.Count > 0)
            {
                Console.Write(characters.Pop());
               
            }
            if (isExist)
            {
                Console.WriteLine();
                Console.WriteLine("a - exist");
            }
        }
    }
}