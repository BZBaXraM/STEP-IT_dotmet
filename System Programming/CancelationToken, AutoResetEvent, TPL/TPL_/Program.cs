
#region TPL

// TPL - Task Paralell Library

//Task task = new Task(() =>
//{
//    TaskMethod("Task1");
//});
//Task task2 = new Task(() =>
//{
//    TaskMethod("Task2");
//});

//task.Start();
//task2.Start();

//var task3 = Task.Run(() => TaskMethod("Task3"));
//var task4 = Task.Factory.StartNew(()=>TaskMethod("Task4"));
//var task5 = Task.Factory.StartNew(()=>TaskMethod("Task5"), TaskCreationOptions.LongRunning);

//var task6 = Task.Run(() => TaskReturnMethod("Task6", 4));

//var result = task6.Result;
//Console.WriteLine(result);




//Console.ReadKey();

//void TaskMethod(string message)
//{
//    Console.WriteLine($"Task -{message} is running" +
//        $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//        $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");

//}

//int TaskReturnMethod(string message, int second)
//{
//    Console.WriteLine($"Task -{message} is running" +
//        $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//        $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
//    Thread.Sleep(second * 1000);
//    return second * 10;
//}
#endregion

#region Continue

using System.Threading.Tasks;

//var firstTask = new Task<int>(() => TaskReturnMethod("FirstTask", 3));
//var secondTask = new Task<int>(() => TaskReturnMethod("SecondTask", 5));

//firstTask.ContinueWith((tsk) =>
//{
//    //Console.WriteLine($"FirstTask Result -{tsk.Result}" +
//    //    $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//    //    $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
//    WaitTaskRunMethod(tsk.Result);
//}, TaskContinuationOptions.OnlyOnRanToCompletion);


//secondTask.ContinueWith((tsk) =>
//{
//    Console.WriteLine(secondTask.Status);
//    Console.WriteLine($"SecondTask Result -{tsk.Result}" +
//       $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//       $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
//}, TaskContinuationOptions.ExecuteSynchronously);
//firstTask.Start();
//secondTask.Start();

//while (!secondTask.IsCompleted)
//{
//    Console.WriteLine(secondTask.Status);
//    Thread.Sleep(500);
//}
//Console.WriteLine(secondTask.Status);

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(100);
//}
//Task.WaitAll(firstTask, secondTask);
//Task.WaitAny(firstTask, secondTask);
// WhenAll, WhenAny
//Thread.Sleep(100);
//Console.WriteLine("End");
//Console.ReadKey();



//int TaskReturnMethod(string message, int second)
//{
//    Console.WriteLine($"Task -{message} is running" +
//        $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//        $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
//    Thread.Sleep(second * 1000);
//    return second * 10;
//}

//void WaitTaskRunMethod(int result)
//{
//    Console.WriteLine($"FirstTask Result -{result}" +
//       $" Id - {Thread.CurrentThread.ManagedThreadId}" +
//       $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
//}

#endregion


#region Child Parent

var firstTask = new Task<int>(() => {

    var innerTask = Task.Factory.StartNew(() => TaskReturnMethod("Dad  Grandson task", 5),
        TaskCreationOptions.AttachedToParent);
    
    innerTask.ContinueWith(tsk => {
        TaskReturnMethod("Son Dadson child", 7);
    }, TaskContinuationOptions.AttachedToParent);

    return TaskReturnMethod("Grand task", 2);

});
firstTask.Start();
firstTask.Wait();
Console.WriteLine("End all");



int TaskReturnMethod(string message, int second)
{
    Console.WriteLine($"Task -{message} is running" +
        $" Id - {Thread.CurrentThread.ManagedThreadId}" +
        $" IsThreadPool - {Thread.CurrentThread.IsThreadPoolThread}");
    Thread.Sleep(second * 1000);
    Console.WriteLine($"{message} end work");
    return second * 10;
}

#endregion
