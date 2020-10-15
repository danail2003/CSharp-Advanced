using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader("Input.txt"))
            {
                int counter = 0;
                string line = streamReader.ReadLine();

                using(StreamWriter streamWriter = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }

                        counter++;
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
