using System;
using System.Text;

namespace Files
{
    
    internal class Program
    {
        static void WriteFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Console.WriteLine("Enter data to write file: ");
            string writeText = Console.ReadLine();
            byte[] buffer = Encoding.Default.GetBytes(writeText);
            fs.Write(buffer, 0, writeText.Length);
            Console.WriteLine("Information recorded");
            fs.Close();
        }
        static string ReadFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] buffer = new byte[(int)fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                return Encoding.Default.GetString(buffer);
            }
        }
        static void Main(string [] args)
        {
            string path = "text.bin";
            WriteFile(path);
            Console.WriteLine(ReadFile(path));
        }
    }
}