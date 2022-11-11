using System.IO;
namespace DemoFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\file1.txt";
            string targetPath = @"D:\target.txt"; 
            try
            {
                //File.Copy(sourcePath,targetPath);
                //ele cria arquivo neste caminho e com este nome @"D:\target.txt"
                //se ja foi criado tera exeção The file 'D:\target.txt' already exists.
                //apage o arquivo execute
                File.Copy(sourcePath,targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}