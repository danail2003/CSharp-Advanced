using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string expression = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
