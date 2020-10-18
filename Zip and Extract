using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main()
        {
            string startPath = @"C:\copyMe.png";
            string zipPath = @"C:\";
            string extractPath = @"D:\";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
