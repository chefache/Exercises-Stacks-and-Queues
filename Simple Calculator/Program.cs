using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 + 5 + 10 - 2 - 1	14

            var inputString = Console.ReadLine();
            var inputExpression =  inputString.Split(" ");

            var myStack = new Stack<string>(inputExpression.Reverse());

            var result = 0;

            while (myStack.Count > 0)
            {
                var currentSymbol = myStack.Pop();
                if (currentSymbol == "+")
                {
                    var number = myStack.Pop();
                    result += int.Parse(number);

                }
                else if (currentSymbol == "-")
                {
                    var number = myStack.Pop();
                    result -= int.Parse(number);
                }
                else
                {
                    result = int.Parse(currentSymbol);
                }
            }
            Console.WriteLine(result);

        }
    }
}
