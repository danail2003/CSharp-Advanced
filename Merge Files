using System;
using System.IO;
using System.Collections.Generic;

namespace Merge_Files
{
    class Program
    {
        static void Main()
        {
            StreamReader streamReader = new StreamReader("FileOne.txt");
            StreamReader streamReader1 = new StreamReader("FileTwo.txt");

            List<string> text = new List<string>();

            using (streamReader)
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    text.Add(line);

                    line = streamReader.ReadLine();
                }
            }

            using (streamReader1)
            {
                string line = streamReader1.ReadLine();

                while (line != null)
                {
                    text.Add(line);

                    line = streamReader1.ReadLine();
                }
            }

            text.Sort();

            File.WriteAllText("Output.txt", string.Join($"{Environment.NewLine}", text));
        }
    }
}
