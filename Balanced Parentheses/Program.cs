using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            var pairBrackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            if (expression.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            var openningBrackets = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(' || ch == '[' || ch == '{')
                {
                    openningBrackets.Push(ch);
                }
                else if (openningBrackets.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    char lastOpeningBracket = openningBrackets.Pop();
                    char expecteClosingBracket = pairBrackets[lastOpeningBracket];

                    if (ch != expecteClosingBracket)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
