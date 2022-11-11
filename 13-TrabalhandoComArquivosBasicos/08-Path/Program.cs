namespace _08_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";
        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); //DirectorySeparatorChar: \
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);                   //PathSeparator: ;
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));       //GetDirectoryName: c:\temp\myfolder
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));                 //GetFileName: file1.txt
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));               //GetExtension: .txt
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));//GetFileNameWithoutExtension: file1
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));                 //GetFullPath: c:\temp\myfolder\file1.txt
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());                 //GetTempPath: C:\Users\Mazola\AppData\Local\Temp\
        }
    }
}