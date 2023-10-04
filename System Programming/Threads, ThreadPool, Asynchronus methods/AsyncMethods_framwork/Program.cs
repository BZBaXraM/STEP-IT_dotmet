using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods_framwork
{





    internal class Program
    {
        delegate void SomeDelegate();
        static void someMethod()
        {
            Console.WriteLine($"Some method thread id: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Some method thread is background: {Thread.CurrentThread.IsBackground}");
        }
        static void Main(string[] args)
        {
            //var del = new SomeDelegate(someMethod);
            //var result = del.BeginInvoke(null, null);

            //Console.WriteLine($"Main method thread id: {Thread.CurrentThread.ManagedThreadId}");
            //del.EndInvoke(result);
            //Console.WriteLine($"Main method thread is background: {Thread.CurrentThread.IsBackground}");
            ThreadPool.GetAvailableThreads(out int workerCount, out int complCount);
            Console.WriteLine(workerCount);
        }
    }
}
