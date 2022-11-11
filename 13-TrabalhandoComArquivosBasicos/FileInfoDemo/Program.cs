namespace FileInfoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\file1.txt";
            string targetPath = @"D:\target.txt";
            try
            {

                //Apagar arquivo para testes
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
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