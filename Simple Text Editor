using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < count; i++)
            {
                string[] parts = Console.ReadLine().Split();

                if (parts[0] == "1")
                {
                    stack.Push(text);
                    text += parts[1];
                }
                else if (parts[0] == "2")
                {
                    stack.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(parts[1]));
                }
                else if (parts[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(parts[1]) - 1]);
                }
                else if (parts[0] == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
