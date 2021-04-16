using System.IO;

namespace Line_Numbers_2
{
    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("text.txt");           

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = 0;
                int punctuationMatks = 0;
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (char.IsLetter(currentLine[j]))
                    {
                        letters++;
                    }
                    else if (char.IsPunctuation(currentLine[j]))
                    {
                        punctuationMatks++;
                    }
                }

                lines[i] = $"Line {i + 1}: {currentLine} ({letters})({punctuationMatks})";
            }

            File.WriteAllLines("Output.txt", lines);
        }
    }
}
