using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            string[] expression = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                char operation = char.Parse(stack.Pop());
                int secondNumber = int.Parse(stack.Pop());

                if (operation == '+')
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if (operation == '-')
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
