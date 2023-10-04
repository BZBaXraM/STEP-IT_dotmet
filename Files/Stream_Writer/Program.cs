using System;
using System.Text;

namespace Stream_Writer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = "text.txt";
            //using (FileStream fs = new FileStream(path, FileMode.Create))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
            //    {
            //        string writeText = Console.ReadLine();
            //        foreach (var item in writeText)
            //        {
            //            sw.Write($"{item} ");
            //        }
            //    }
            //}

            //using (FileStream fs = new FileStream(path, FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
            //    {
            //        Console.WriteLine(sr.ReadToEnd());
            //    }
            //}

        }
    }
}
