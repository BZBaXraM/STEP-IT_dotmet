
#region Thread interrupt
//Thread thread = new Thread(Download);
//thread.Start();

//var key = Console.ReadKey();
//if (key.Key == ConsoleKey.Enter)
//{
//    thread.Interrupt();
//}
#endregion
using (CancellationTokenSource cts = new CancellationTokenSource())
{
    CancellationToken token = cts.Token;
    ThreadPool.QueueUserWorkItem(o =>
    {
        try
        {
            Download(token);
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Interrupt download");
        }
    });
    Console.ReadKey();
    cts.Cancel();
    Thread.Sleep(10000);
    Console.WriteLine("End of Code");
}




void Download(CancellationToken token)
{
    Console.WriteLine("Download start...");

    Thread.Sleep(5000);
    //if (token.IsCancellationRequested)
    //{
    //    Console.WriteLine("Interrupt");
    //    return;
    //}
    token.ThrowIfCancellationRequested();
    Console.WriteLine("Download End...");
}

