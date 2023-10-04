//ThreadPool.GetAvailableThreads(out int workerCount, out int complCount);
//Console.WriteLine(workerCount);
//Console.WriteLine(complCount);

using System.ComponentModel;


Console.WriteLine("Main method start...");
//AsyncOperation("Salam");
//ThreadPool.QueueUserWorkItem(AsyncOperation, "Salam");
ThreadPool.QueueUserWorkItem(o => {
    SomeOtherOperation();
});
Console.WriteLine($"Main thread Id: {Thread.CurrentThread.ManagedThreadId}");
Thread.Sleep(200);
Console.WriteLine("Main method end...");

void AsyncOperation(object state)
{
    Console.WriteLine("AsyncOperation method start...");
    Console.WriteLine(state.ToString());
    Thread.Sleep(1000);
    Console.WriteLine($"Worker thread Id: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine("AsyncOperation method end...");
}

void SomeOtherOperation()
{
    Console.WriteLine("SomeOtherOperation method start...");
    Thread.Sleep(1000);
    Console.WriteLine($"Worker thread Id: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine("SomeOtherOperation method end...");
}


