namespace _06_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para teste adicinar arquivos
            string sourcePath = @"D:\file1.txt";
            string targetPath = @"D:\target.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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