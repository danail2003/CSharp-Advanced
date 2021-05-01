using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main()
        {
            StreamReader streamReader = new StreamReader("Input.txt");
            int counter = 0;

            using (streamReader)
            {
                string line = streamReader.ReadLine();

                using (StreamWriter streamWriter = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        counter++;

                        Console.WriteLine($"{counter}. {line}");
                        line = streamReader.ReadLine();
                    }

                    streamWriter.Flush();
                }
            }
        }
    }
}
