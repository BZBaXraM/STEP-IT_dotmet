using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Generics
{
    internal sealed class OperationTimer : IDisposable
    {
        long _startTime;
        string _text;
        int _collectionCount;
        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;
            // сохраняется количество сборок мусора, 
            // выполненных на текущий момент
            _collectionCount = GC.CollectionCount(0);
            // сохраняется начальное время
            _startTime = Stopwatch.GetTimestamp();
        }
        /// <summary>
        /// Вызывается при разрушении объекта
        /// Выводит:
        /// значение времени, прошедшего с момента
        /// создания объекта до момента его удаления
        /// количество выполненных сборок мусора, 
        /// выполненных за это время
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine($"{ _text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} секунды(сборок мусора {GC.CollectionCount(0) - _collectionCount})");
        }
        /// <summary>
        /// Метод удаляются все неиспользуемые объекты
        /// Это надо для "чистоты эксперимента",
        /// т.е. чтобы сборка мусора происходила только
        /// для объектов, которые будут создаваться 
        /// в профилируемом блоке кода
        ///</summary>
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
    internal class Program
    {

        /// <summary>
        /// метод для тестирования производительности 
        /// обобщенного и необобщенного списка
        /// </summary>
        private static void ValueTypePerfTest()
        {
            const int COUNT = 10000000;
            // объект OperationTimer создается
            // перед началом использования коллекции
            // после завершения ее использования 
            // выводит время, затраченное на работу 
            // с коллекцией 
            using (new OperationTimer("List"))
            {
                //использование обобщенного списка
                List<int> list = new List<int>(COUNT);
                for (int n = 0; n < COUNT; n++)
                {
                    list.Add(n);
                    int x = list[n];
                }
                list = null; // для гарантированного 
                             // выполнения сборки мусора
            }
            using (new OperationTimer("ArrayList"))
            {
                // использование необобщенного списка
                ArrayList array = new ArrayList();
                for (int n = 0; n < COUNT; n++)
                {
                    array.Add(n); // выполняется упаковка
                    int x = (int)array[n]; // выполняется 
                                           // распаковка
                }
                array = null; // для гарантированного 
                              // выполнения сборки мусора
            }
        }

        static void Main(string[] args)
        {
            #region boxing unboxing
            //// Boxing Unboxing
            //object obj = 25; // boxing
            //Console.WriteLine($"Boxing {obj}");
            //int number = (int)obj; // unboxing
            //Console.WriteLine($"Unboxing {number}");
            #endregion

            #region List<T>

            //List<int> lst = new List<int>() { 25, 65, 65, 4, 2, 43 };
            //lst.Add(1);
            //foreach (var item in lst)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(lst[0]);
            //Console.WriteLine(lst.Average());
            //Console.WriteLine(lst.Sum());
            #endregion

            // Richter test (generic nongeneric)
            //ValueTypePerfTest();


            #region Dictionary<T>

            //Dictionary<string, int> dict = new Dictionary<string, int>()
            //{
            //    ["three"] = 3,
            //    ["hello"] = 678
            //};
            //dict.Add("one", 1);
            //dict["two"] = 2;
            //Console.WriteLine(dict["two"]);
            //dict["two"] = 35;
            //Console.WriteLine(dict["two"]);

            //foreach (KeyValuePair<string, int> kvp in dict)
            //{
            //    Console.WriteLine(kvp);
            //}
            
            #endregion

            // Итераторы yield, generic Classes, generic methods
            // 
        }
    }
}
