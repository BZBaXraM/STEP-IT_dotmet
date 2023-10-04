using System;
using System.Collections;

namespace Collections_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ICollection, IList, IDictionary, IDictionaryEnumerator

            SortedArrayList list = new SortedArrayList();
            list.AddSorted(200);
            list.AddSorted(-65);
            list.AddSorted(0);
            list.AddSorted(2568);
            list.AddSorted(-25);
            list.AddSorted(-65);

            foreach (int i in list)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}