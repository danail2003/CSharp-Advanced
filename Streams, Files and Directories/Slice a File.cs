using System;
using System.IO;
using System.Collections.Generic;

namespace Slice_a_File
{
    class Program
    {
        static void Main()
        {
            string output = @"C:\Users\I am\source\repos\Streams, Files and Directories\Slice a File\bin\Debug\netcoreapp3.1";
            string file = @"C:\Users\I am\source\repos\Streams, Files and Directories\Slice a File\sliceMe.txt";
            int parts = 4;
            List<string> files = new List<string>() { "Part-1", "Part-2", "Part-3", "Part-4" };

            using (FileStream bigFile = new FileStream(file, FileMode.Open))
            {
                long piece = (long)Math.Ceiling((double)bigFile.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentSize = 0;

                    using (FileStream createFile = new FileStream(files[i], FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (bigFile.Read(buffer, 0, buffer.Length) == buffer.Length)
                        {
                            currentSize += buffer.Length;
                            createFile.Write(buffer, 0, buffer.Length);

                            if (currentSize >= piece)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
