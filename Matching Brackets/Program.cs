using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5


            string input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var @char = input[i];
               
                if (@char == '(')
                {
                    stack.Push(i);
                }
                else if (@char == ')')
                {
                    var firstOpen = stack.Pop();
                    var exprssion = input.Substring(firstOpen, i - firstOpen + 1);
                    Console.WriteLine(exprssion);
                }
            }
   
        }
    }
}
