using System;


namespace Exceptions_part2
{
    class Program
    {
        static void foo2()
        {
            throw new Exception("My exception");
        }
        static void foo1()
        {
            foo2 ();
        }

        static void foo()
        {
            try
            {
                foo1();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine($"Stack trace:\n{ex.StackTrace}");
            }
            finally { Console.WriteLine("Finally"); }
        }
        static void Main()
        {
            #region Последовательность catch блоков
            //int numb1, numb2, result = 0;

            //Console.WriteLine("Enter two number");
            //try
            //{
            //    throw new Exception("Any exception");
            //    numb1 = int.Parse(Console.ReadLine());
            //    numb2 = int.Parse(Console.ReadLine());
            //    result = numb1 / numb2;
            //    Console.WriteLine($"{numb1} / {numb2} = {result}");

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex) // поймает любые exception которые наследуются от класса Exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch // поймает любые exception (даже если это в небезпасном коде)
            //{
            //{
            //    Console.WriteLine("Empty catch");
            //}

            //finally
            //{
            //    Console.WriteLine("Finally");
            //}
            //Console.WriteLine("End of code");
            #endregion

            #region вложенные try
            //int numb1, numb2, result = 0;
            //try //внешний блок
            //{
            //    // A
            //    numb1 = int.Parse(Console.ReadLine());
            //    try //внутренный блок
            //    {
            //        // B
            //        numb2 = int.Parse(Console.ReadLine());
            //        result = numb1 / numb2;
            //        Console.WriteLine($"{numb1} / {numb2} = {result}");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine($"Внутренный:\n{ex.Message}");
            //    }
            //    //catch (FormatException ex)
            //    //{
            //    //    Console.WriteLine($"Внутренный:\n{ex.Message}");
            //    //}

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Внешний :\n{ex.Message}");
            //    Console.WriteLine($"Внешний :\n{ex.StackTrace}");
            //}
            #endregion

            foo();
        }
    }
}