#region AutoResetEvent
AutoResetEvent _workerEvent = new AutoResetEvent(false);
AutoResetEvent _mainEvent = new AutoResetEvent(false);

Thread thread = new Thread(() => {
    SomeProcess(10);
});
thread.Start();  //1. 

Console.WriteLine("Waiting SomeProcess");
_workerEvent.WaitOne();
// 3. start
Console.WriteLine("Starting SomeProcess...");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Main - {i}");
    Thread.Sleep(1000);
}
// 3. end
_mainEvent.Set();
Console.WriteLine("Worker is doing some job");
_workerEvent.WaitOne();
// 5. start
Console.WriteLine("Complete");

void SomeProcess(int seconds)
{
    // 2. start
    Console.WriteLine("Starting Some Process");
    Thread.Sleep(TimeSpan.FromSeconds(seconds));
    Console.WriteLine("Okay");
    // 2. end
    _workerEvent.Set();
    Console.WriteLine("Main thread is working");
    _mainEvent.WaitOne();
    // 4. start
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Some Process {i}");
        Thread.Sleep(TimeSpan.FromSeconds(1));
    }
    // 4 end
    _workerEvent.Set();
}

#endregion
