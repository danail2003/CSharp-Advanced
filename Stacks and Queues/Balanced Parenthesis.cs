using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main()
        {
            string paranthesis = Console.ReadLine();
            Stack<char> firstHalf = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < paranthesis.Length; i++)
            {
                if (paranthesis[i] == '(')
                {
                    firstHalf.Push(paranthesis[i]);
                }
                else if (paranthesis[i] == '[')
                {
                    firstHalf.Push(paranthesis[i]);
                }
                else if (paranthesis[i] == '{')
                {
                    firstHalf.Push(paranthesis[i]);
                }
                else if (paranthesis[i] == ']')
                {
                    if (!firstHalf.Any() || firstHalf.Pop() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (paranthesis[i] == '}')
                {
                    if (!firstHalf.Any() || firstHalf.Pop() != '{')
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (paranthesis[i] == ')')
                {
                    if (!firstHalf.Any() || firstHalf.Pop() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
