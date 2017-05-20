using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo fsi = new DirectoryInfo(@"D:\abcd");
            FileSystemInfo[] fi = fsi.GetFileSystemInfos();

            string line = "";


            for (int i = 0; i < fi.Length; i++)
            {
                using (FileStream fs = new FileStream(fi[i].FullName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            for (int j = 0; j < line.Length; j++)
                            {
                                if (line[j] == 'h' && line[j + 1] == 'e' && line[j + 2] == 'l' && line[j + 3] == 'l' && 
                                    line[j+4] == 'o' && line[j + 5] == ' ' && line[j + 6] == 'w' && line[j + 7] == 'o' &&
                                    line[j+8] == 'r' && line[j + 9] == 'l' && line[j + 10] == 'd')
                                {
                                    Console.WriteLine(fi[i].Name);
                                    Console.ReadKey();
                                    break;
                                }
                            }

                        }

                    }
                }
            }
        }
    }
}
