using System;

namespace Methods
{
    class Mathematic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Constructors
    {
        static void ByValueMethod(int[] arr, int numb)
        {
            numb = 5;
            arr[0] = numb;
            arr = new int[5] { 25, 9, 78, 1, 98 };
            Console.WriteLine($"In method: ");
            Console.WriteLine($"numb = {numb}");
            Console.Write($"arr = ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void ByReferenceMethod(ref int numb, ref int[] arr)
        {
            numb = 5;
            arr = new int[] { 1, 2 };
        }

        static void ByReferenceMethod(out int numb)
        {
            numb = 25;
        }

        static void SumArray(int[] arr, out int summ)
        {
            summ = 0;
            foreach (var item in arr)
            {
                summ += item;
            }
        }

        static void SumArray1(int[] arr, ref int summ)
        {
            foreach (var item in arr)
            {
                summ += item;
            }
        }

        static int SumArray2(int[] arr)
        {
            int summ = 0;
            foreach (var item in arr)
            {
                summ += item;
            }
            return summ;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Mathematic.Add(2, 3)); 
            //Console.WriteLine(Mathematic.Add(2, 3, 3));
            #region By Value
            //int numb = 6;
            //int[] arr = new int[5] { 2, 6, 8, 4, 7 };
            //Console.WriteLine($"Before method call: ");
            //Console.WriteLine($"numb = {numb}");
            //Console.Write($"arr = ");
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //ByValueMethod(arr, numb);

            //Console.WriteLine($"After method call: ");
            //Console.WriteLine($"numb = {numb}");
            //Console.Write($"arr = ");
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region By reference
            // ref

            //int numb = 25;
            //int[] arr2 = new int[5] { 2, 6, 8, 4, 7 };
            //Console.WriteLine("Before method:");
            //Console.WriteLine($"numb = {numb}");
            //Console.Write($"arr2 = ");
            //foreach (var item in arr2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //ByReferenceMethod(ref numb, ref arr2);
            //Console.WriteLine("After method:");
            //Console.WriteLine($"numb = {numb}");
            //Console.Write($"arr2 = ");
            //foreach (var item in arr2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            // out
            //ByReferenceMethod(out int n);

            //Console.WriteLine(n);
            int summNormal = 0, summRef = 0;
            int[] array = new int[3] { 1, 2, 3};
            Random rnd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(25, 48);
            //}
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            SumArray(array, out int summOut);
            SumArray1(array, ref summRef);
            summNormal = SumArray2(array);
            Console.WriteLine($"sumOut = {summOut}"); // 6
            Console.WriteLine($"sumRef = {summRef}"); // 6
            Console.WriteLine($"sumNormal = {summNormal}"); // 6

            Console.WriteLine(array);
            
            #endregion

        }
    }
}
