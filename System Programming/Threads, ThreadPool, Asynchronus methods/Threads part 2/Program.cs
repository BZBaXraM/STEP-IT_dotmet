Thread thread = new Thread(some);
thread.IsBackground = true;
thread.Start();
Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
thread.Join();
Console.WriteLine($"Main thread is background: {Thread.CurrentThread.IsBackground}");



void some()
{

    //Console.WriteLine($"some thread id: {Thread.CurrentThread.ManagedThreadId}");
    //Thread.Sleep(100); 
    //Console.WriteLine($"some thread is background: {Thread.CurrentThread.IsBackground}");
    for (int i = 0; i < 500; i++)
    {
        Console.WriteLine($"{i}. some thread id: {Thread.CurrentThread.ManagedThreadId}");

        Console.WriteLine($"some thread is background: {Thread.CurrentThread.IsBackground}");
    }
}
