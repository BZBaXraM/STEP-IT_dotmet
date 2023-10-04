Console.WriteLine($"Main Id {Thread.CurrentThread.ManagedThreadId}");
//SomeMethod();

SomeMethodAsync();

Console.ReadKey();

void SomeMethod()
{
    Console.WriteLine($"Start Id {Thread.CurrentThread.ManagedThreadId}");
    Task.Run(() =>
    {
        Console.WriteLine($"Begin Id {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
        Console.WriteLine($"End Id {Thread.CurrentThread.ManagedThreadId}");
    });
    Console.WriteLine($"Finish Id {Thread.CurrentThread.ManagedThreadId}");

}

async void SomeMethodAsync()
{
    Console.WriteLine($"Start Id {Thread.CurrentThread.ManagedThreadId}");
    await Task.Run(() =>
    {
        Console.WriteLine($"Begin Id {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Begin IsThreadPool {Thread.CurrentThread.IsThreadPoolThread}");
        Thread.Sleep(3000);
        Console.WriteLine($"End Id {Thread.CurrentThread.ManagedThreadId}");
    });
    Console.WriteLine($"Finish Id {Thread.CurrentThread.ManagedThreadId}");
}

// Thread => ThreadPool => TPL => syntax sugar + love = async await