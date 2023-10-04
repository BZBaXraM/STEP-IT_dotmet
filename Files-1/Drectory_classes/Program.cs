using System;
using System.Text;

namespace Directory_classes
{
    internal class Program
    {
        static void WriteFile(FileInfo file)
        {
            using (FileStream fs = file.Open(FileMode.Create,
                                                FileAccess.Write,
                                                FileShare.None))
            {
                Console.WriteLine("\nEnter data to write: ");
                string writeText = Console.ReadLine();
                byte[] buffer = Encoding.Default.GetBytes(writeText);
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        static string ReadFile(FileInfo file)
        {
            using (FileStream fs = file.Open(FileMode.Open,
                                            FileAccess.Read,
                                            FileShare.Read))
            {
                byte[] readBytes = new byte[(int)fs.Length];
                fs.Read(readBytes, 0, readBytes.Length);
                return Encoding.Default.GetString(readBytes);
            }
        }

        static void WriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                string writeText = Console.ReadLine();
                sw.WriteLine(writeText);
                foreach (var item in writeText)
                {
                    sw.Write($"{item} ");
                }
            }
        }
        static string ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                return sr.ReadToEnd();
            }
        }
        static void Main(string[] args)
        {
            #region DirectoryInfo
            //DirectoryInfo directory = new DirectoryInfo(".");
            //Console.WriteLine($"Full path to the directory:\n{directory.FullName}");
            //Console.WriteLine($"Time of creation: {directory.CreationTime}");
            //Console.WriteLine($"\n\tAll directory: ");
            //FileInfo[] files = directory.GetFiles();
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine(file.Name);
            //}
            #endregion

            #region DirectoryInfo2
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Test");
            //if (!dir.Exists)
            //{
            //    dir.Create();
            //}
            //Console.WriteLine($"Last access time: {dir.LastAccessTime}");
            //DirectoryInfo subDir = dir.CreateSubdirectory("Subdir");
            //Console.WriteLine($"Full path: {subDir.FullName}");
            //FileInfo fileInfo = new FileInfo(subDir + @"\Test.bin");
            //WriteFile(fileInfo);

            //Console.WriteLine(ReadFile(fileInfo));
            #endregion

            #region DirectoryInfo3
            //string path_ = @"C:/Test/Subdir/Test.txt";

            //try
            //{
            //    WriteFile(path_);
            //    Console.WriteLine("\n\tRead data:\n");
            //    Console.WriteLine(ReadFile(path_));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine();

            #endregion

            string path = @"C:\Test";
            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine($"Date of catalog creation: " +
            //        $"{Directory.GetCreationTime(path)}");
            //    Console.WriteLine("\n\tSubdirectories:\n");
            //    foreach(string item in Directory.GetDirectories(path))
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("\n\t Logical devices: \n");
            //    foreach(string item in Directory.GetLogicalDrives())
            //    {
            //        Console.WriteLine(item);
            //    }
                //Directory.Delete(path, true);
            //}
                //if (!Directory.Exists(path))
                //{
                //    Console.WriteLine("\nDirectory does not exist\n");
                //}
        }
    }
}