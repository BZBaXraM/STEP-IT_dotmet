using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Salam";
            str = str.Replace('a', 'u');
            StringBuilder stringBuilder = new StringBuilder("Salam");
            Console.WriteLine(stringBuilder.Length); 
            Console.WriteLine(stringBuilder.Capacity);
            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append('a');
                //Console.Write("Length = " + stringBuilder.Length);
                //Console.WriteLine(" Capacity = " + stringBuilder.Capacity);
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
            Console.Write("Length = " + stringBuilder.Length);
            Console.WriteLine(" Capacity = " + stringBuilder.Capacity);
        }
    }
}
