using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList, Stack, Queue, Hashtable, SortedList

            Random random = new Random();

            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine(arrayList.Capacity);
            //arrayList.Add(0);
            //Console.WriteLine(arrayList.Capacity);
            //for (int i = 0; i < 20; i++)
            //{
            //    arrayList.Add(random.Next(10, 100));
            //    Console.WriteLine($"Size = {arrayList.Count}, Capacity = {arrayList.Capacity}");
            //}
            //arrayList.TrimToSize();
            //Console.WriteLine($"Size = {arrayList.Count}, Capacity = {arrayList.Capacity}");

            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            ////arrayList.Add("Salam");
            //arrayList.Sort();
            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Stack
            //Stack stack = new Stack();
            //stack.Push(random.Next(10, 100));
            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);
            #endregion

            #region Queue
            //Queue queue = new Queue();
            //for (int i = 0; i < 5; i++)
            //{
            //    queue.Enqueue(i);
            //    Console.WriteLine($"Count = {queue.Count}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //    Console.WriteLine($"Count = {queue.Count}");
            //}
            #endregion

            #region Hashtable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "First");
            //hashtable.Add(2, "Second");

            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(hashtable[item]);
            //}
            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable stud = new Hashtable();
            //stud.Add("one", new Student
            //{
            //    FirstName = "Anjelina",
            //    LastName = "Jolie",
            //    BirthDate = new DateTime(1975, 6, 4)

            //});
            //stud.Add("two", new Student
            //{
            //    FirstName = "Monika",
            //    LastName = "Bellucci",
            //    BirthDate = new DateTime(1964, 9, 30)

            //});
            //stud.Add("three", new Student
            //{
            //    FirstName = "Nadir",
            //    LastName = "Zamanov",
            //    BirthDate = new DateTime(1980, 10, 7)
            //});

            //foreach (var item in stud.Keys)
            //{
            //    Console.WriteLine($"{item} - {((Student)(stud[item])).FirstName}");
            //}
            ////stud.Remove("one");

            //foreach (var item in stud.Keys)
            //{
            //    Console.WriteLine($"{item} - {((Student)(stud[item])).FirstName}");
            //}
            #endregion


            #region SortedList
            //SortedList stud = new SortedList();
            //stud.Add(1, new Student
            //{
            //    FirstName = "Anjelina",
            //    LastName = "Jolie",
            //    BirthDate = new DateTime(1975, 6, 4)

            //});
            //stud.Add(2, new Student
            //{
            //    FirstName = "Monika",
            //    LastName = "Bellucci",
            //    BirthDate = new DateTime(1964, 9, 30)

            //});
            //stud.Add(3, new Student
            //{
            //    FirstName = "Nadir",
            //    LastName = "Zamanov",
            //    BirthDate = new DateTime(1980, 10, 7)
            //});

            //foreach (var item in stud.Keys)
            //{
            //    Console.WriteLine($"{item} - {((Student)(stud[item])).FirstName}");
            //}
            #endregion

        }
    }
}