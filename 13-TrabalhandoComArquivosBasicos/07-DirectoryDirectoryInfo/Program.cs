namespace _07_DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\PASTA-TESTE";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                //Directory.CreateDirectory(path+"\\newmaza"); 
                Directory.CreateDirectory(path + @"\newfoldermaza");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }

}