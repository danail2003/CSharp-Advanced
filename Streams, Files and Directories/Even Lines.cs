using System;
using System.IO;
using System.Collections.Generic;

namespace Even_Lines
{
    class Program
    {
        static void Main()
        {
            StreamReader streamReader = new StreamReader("text.txt");
            List<char> symbols = new List<char>();
            string text = "";
            int counter = 0;
            string endText = "";

            using (streamReader)
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            symbols.Add(line[i]);
                        }

                        for (int i = 0; i < symbols.Count; i++)
                        {
                            if (symbols[i] == '-')
                            {
                                symbols[i] = '@';
                            }
                            else if (symbols[i] == ',')
                            {
                                symbols[i] = '@';
                            }
                            else if (symbols[i] == '.')
                            {
                                symbols[i] = '@';
                            }
                            else if (symbols[i] == '!')
                            {
                                symbols[i] = '@';
                            }
                            else if (symbols[i] == '?')
                            {
                                symbols[i] = '@';
                            }
                        }

                        for (int i = 0; i < symbols.Count; i++)
                        {
                            text += symbols[i];
                        }

                        string[] reverse = text.Split();

                        for (int i = reverse.Length; i > 0; i--)
                        {
                            endText += reverse[i - 1] + " ";
                        }

                        using (StreamWriter streamWriter = new StreamWriter("Output.txt"))
                        {
                            Console.WriteLine(endText);
                            symbols.Clear();
                            text = "";
                            endText = "";
                        }
                    }

                    counter++;
                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
