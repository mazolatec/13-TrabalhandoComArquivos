namespace FileFileInfoIOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sourcePath = "c:\\temp\\file1.txt";
            string sourcePath = @"D:\7.4.4 DECODE SOIC8 95160 8331.bin";
            //string sourcePath = @"D:\Backup.MPC";
            string targtPath = @"D:\Backupmp1.bin";




            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // fileInfo.CopyTo(targtPath);

                byte[] lines = File.ReadAllBytes(sourcePath);
                int numberLines = 0;
                int totalFile = lines.Length;
                int numberLinesOffSet = 0;

                foreach (var item in lines)
                {
                    if (numberLines == 0)
                    {
                        Console.Write( numberLines.ToString("X") + " ");
                        
                    }


                    if (item.ToString().Length == 1 
                        || item == 0xA 
                        || item == 0xB 
                        || item == 0xC 
                        || item == 0xD 
                        || item == 0xE 
                        || item == 0xF)
                    {
                        if (numberLines < 15)
                        {
                            Console.Write(" " + "0" + item.ToString("X"));
                        }else if (numberLines == 16)
                        {
                            Console.WriteLine();
                            Console.Write(numberLinesOffSet.ToString("X")); 
                            Console.Write(" " + "0" + item.ToString("X"));
                            numberLines = 0;
                        }

                    }
                    else
                    {
                        Console.Write(" " + item.ToString("X"));
                        if (numberLines == 16)
                        {
                            Console.WriteLine();
                            Console.Write(numberLinesOffSet.ToString("X"));
                            numberLines = 0;
                           // numberLinesOffSet -= 1;
                        }
                    }

                    numberLines++;
                    numberLinesOffSet++;
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.ToString());
            }
        }

        public static int casasDecimais(int d)
        {
            int res = 0;
            while (d != (long)d)
            {
                res++;
                d = d * 10;
            }
            return res;
        }

    }
}