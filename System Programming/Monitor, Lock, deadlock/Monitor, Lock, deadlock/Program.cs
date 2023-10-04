#region ALbahari tricks

//for (int i = 0; i < 10; i++)
//{
//    int temp = i;
//    new Thread(() =>
//    Console.WriteLine(i))
//        .Start();
//}


//string text = "Nadir";
//Thread thread1 = new Thread(() => Console.WriteLine(text));

//text = "Alb";
//Thread thread2 = new Thread(() => Console.WriteLine(text));

//thread1.Start();
//thread2.Start();

#endregion

// Critical section - когда потоки обращаются к общей памяти

#region Interlocked

//Thread[] threads = new Thread[5];

//for (int i = 0; i < 5; i++)
//{
//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            Interlocked.Increment(ref Counter.Count);

//            if (Counter.Count % 2 != 0)
//            {
//                Interlocked.Increment(ref Counter.CountOdd);

//            }
//            //Counter.Count++;
//        }
//    });
//}
//for (int i = 0; i < 5; i++)
//{
//    threads[i].Start();
//}

//for (int i = 0; i < 5; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);
//Console.WriteLine(Counter.CountOdd);

#endregion

// Monitor - class, Lock - syntax sugar

#region Monitor

//Thread[] threads = new Thread[5];
//object obj = new object();
//for (int i = 0; i < 5; i++)
//{

//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            Monitor.Enter(obj);
//            try
//            {
//                Counter.Count++;

//                if (Counter.Count % 2 != 0)
//                {
//                    Counter.CountOdd++;

//                }
//            }
//            finally
//            {
//                Monitor.Exit(obj);
//            }

//        }
//    });
//}
//for (int i = 0; i < 5; i++)
//{
//    threads[i].Start();
//}

//for (int i = 0; i < 5; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);
//Console.WriteLine(Counter.CountOdd);

#endregion

#region Lock

//Thread[] threads = new Thread[5];
//object obj = new object();
//for (int i = 0; i < 5; i++)
//{

//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            lock (obj)
//            {
//                Counter.Count++;

//                if (Counter.Count % 2 != 0)
//                {
//                    Counter.CountOdd++;

//                }
//            }

//        }


//    });
//}
//for (int i = 0; i < 5; i++)
//{
//    threads[i].Start();
//}

//for (int i = 0; i < 5; i++)
//{
//    threads[i].Join();
//}

//Console.WriteLine(Counter.Count);
//Console.WriteLine(Counter.CountOdd);

#endregion

object object1 = new object();
object object2 = new object();

Thread thread1 = new Thread(ObliviousFunction);
Thread thread2 = new Thread(BlindFunction);

thread1.Start();
thread2.Start();

while (true)
{
    // Stare at the two threads in deadlock.
}


void ObliviousFunction()
{
    Console.WriteLine("ObliviousFunction");
    lock (object1)
    {
        Thread.Sleep(1000); // Wait for the blind to lead
        lock (object2)
        {
        }
    }
}

void BlindFunction()
{
    Console.WriteLine("BlindFunction");
    lock (object2)
    {
        Thread.Sleep(1000); // Wait for oblivion
        lock (object1)
        {
        }
    }
}


class Counter
{
    public static int Count = 0;
    public static int CountOdd = 0;
}
