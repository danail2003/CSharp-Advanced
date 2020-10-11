using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main()
        {
            string input = @"C:\Users\I am\source\repos\Streams, Files and Directories\Copy Binary File\bin\Debug\netcoreapp3.1\copyMe.png";
            string output = @"C:\Users\I am\source\repos\Streams, Files and Directories\Copy Binary File\bin\Debug\netcoreapp3.1\copyMe2.png";

            using (FileStream file = new FileStream(input, FileMode.Open))
            {
                using(FileStream newFile = new FileStream(output, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int bytes = 0;

                    while ((bytes = file.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        newFile.Write(buffer, 0, bytes);
                    }
                }
            }
        }
    }
}
