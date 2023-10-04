using System;

namespace TypeCasting
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 2.5;
            //a = b; // Error - Неявный typecasting double to int запрещено
            //a = (int)b; // Явный typecasting
            // b = a; // Неявный typecasting int to double запрещено

            //bool ch = (bool)a; // Error
            //Console.WriteLine(ch);

        }
    }
}
