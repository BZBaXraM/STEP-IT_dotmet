//Console.WriteLine(Thread.CurrentThread.ManagedThreadId); 
//Console.WriteLine(Thread.CurrentThread.IsBackground); 


Thread thread = new Thread(
    () =>
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {i}");
    }
});

Thread thread2 = new Thread(SomeMethod);
//thread.Priority = ThreadPriority.Highest;
//thread2.Priority = ThreadPriority.Lowest;
thread.Start();
thread2.Start();


for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"\t\t{Thread.CurrentThread.ManagedThreadId} - {i}");
}


void SomeMethod()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"\t{Thread.CurrentThread.ManagedThreadId} - {i}");
    }
}