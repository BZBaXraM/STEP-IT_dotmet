using System;
using System.Text;

namespace Strings {
    class Program {
        static void Main(string[] args) {
            //string name = "Salam";
            //name = name.Replace('a', 'u');
            //Console.WriteLine(name);
            //Console.WriteLine(name[^1]);
            //Console.WriteLine(name[1..3]);

            //string s = new('-', 25);
            ////Console.WriteLine(s);
            //string myString = s + "Salam" + s;
            //Console.WriteLine(myString);

            string str1 = "Nadir";
            string str2 = "Wadir";

            Console.WriteLine(str1 == str2);

            //Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str2.IndexOf("bad"));
            char[] ss = new char[3] { 'd', 'a', 'W' };
            Console.WriteLine(str2.IndexOfAny(ss));            
        }
    }
}
