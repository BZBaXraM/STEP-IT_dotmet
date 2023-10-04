#region Mutex
//Mutex mutex = new();
//int numb = 1;
//for (int i = 0; i < 5; i++)
//{
//    Thread thread = new Thread(Count);
//    thread.Name = $"Thread №{i}";
//    thread.Start();
//}

//void Count()
//{
//    mutex.WaitOne();
//    numb = 1;
//    for (int i = 0; i < 10; i++)
//    {

//        Console.WriteLine($"{Thread.CurrentThread.Name}: {numb}");
//        numb++;
//        Thread.Sleep(10);

//    }
//    mutex.ReleaseMutex();
//}
#endregion

#region Mutex Global
//string MutexName = "Salam Salamzade";
//using (var mutex = new Mutex(false, MutexName))
//{
//    if (!mutex.WaitOne(30000))
//    {
//        Console.WriteLine("Other instance is running");
//        Thread.Sleep(1000);
//        return;
//    }
//    else
//    {
//        Console.WriteLine("My code is running");
//        Console.ReadKey();
//        Thread.Sleep(100);
//        mutex.ReleaseMutex();
//    }

//}
#endregion

#region Semaphore
//Semaphore semaphore = new Semaphore(3, 3, "mySem");

//for (int i = 0; i < 15; i++)
//{
//    ThreadPool.QueueUserWorkItem(Some, semaphore);
//}
//Console.ReadKey();
//void Some(object state)
//{
//    var s = state as Semaphore;
//    bool st = false;
//    while (!st)
//    {
//        if (s.WaitOne(500))
//        {
//            try
//            {
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} " +
//                    $"взял ключь.");
//                Thread.Sleep(10000);
//            }
//            finally
//            {
//                st = true;
//                Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} " +
//                    $"отдал ключь.");
//                s.Release();
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Mr. {Thread.CurrentThread.ManagedThreadId} " +
//                   $"простите, но пока нету свободных кабинетов.");
//        }
//    }
//}
#endregion



#region SemaphoreSlim
SemaphoreSlim slim = new SemaphoreSlim(4);
for (int i = 0; i < 6; i++)
{
    var name = $"Thread-{i}";
    int seconds = 2 + 2 * i;
    Thread thread = new Thread(() =>
    {
        AccessDataBase(name, seconds);
    });    
    thread.Start();
}

void AccessDataBase(string name, int seconds)
{
    Console.WriteLine($"{name} wait for access");
    slim.Wait();
    Console.WriteLine($"{name} is working {seconds} seconds on database...");
    Thread.Sleep(seconds * 1000);
    Console.WriteLine($"{name} is complete...");
    slim.Release();
}
#endregion
