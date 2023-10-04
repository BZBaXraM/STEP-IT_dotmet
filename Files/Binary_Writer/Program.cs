using System;
using System.Text;

namespace Binary_Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "test.dat";
            //using (FileStream fs = new FileStream(path, FileMode.Create))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
            //    {
            //        string writeText = Console.ReadLine();
            //        double e = 2.7182818284;
            //        int number = 2212;
            //        bw.Write(writeText);
            //        bw.Write(number);
            //        bw.Write(e);
            //    }
            //}


            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
                {
                    string ReadText = br.ReadString();
                    int read_number = br.ReadInt32();
                    double read_e = br.ReadDouble();
                    Console.WriteLine(ReadText);
                    Console.WriteLine(read_number);
                    Console.WriteLine(read_e);                    
                }
            }

        }
    }
}