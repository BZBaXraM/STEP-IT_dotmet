﻿using System.Runtime.CompilerServices;
Console.WriteLine($"Main Id {Thread.CurrentThread.ManagedThreadId}");
SomeClass some = new();
//some.SomeMethod();
some.SomeAsyncMethod();

Console.ReadLine();

class SomeClass
{
    public void SomeMethod()
    {
        Console.WriteLine($"Current Id {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Begin");
        Thread.Sleep(2000);
        Console.WriteLine("End");
    }
    public void SomeAsyncMethod()
    {
        AsyncStateMachine stateMachine = new AsyncStateMachine();
        stateMachine.outer = this;
        stateMachine.builder = AsyncVoidMethodBuilder.Create();
        stateMachine.state = -1;
        stateMachine.builder.Start(ref stateMachine);
    }


    private struct AsyncStateMachine : IAsyncStateMachine
    {
        public int state;
        public SomeClass outer;
        private TaskAwaiter awaiter;
        public AsyncVoidMethodBuilder builder;
        public void MoveNext()
        {
            if (state == -1)
            {
                Console.WriteLine($"Start Id: {Thread.CurrentThread.ManagedThreadId}");
                Task t = Task.Factory.StartNew(outer.SomeMethod);
                awaiter = t.GetAwaiter();
                state = 0;
                builder.AwaitOnCompleted(ref awaiter, ref this);
            }
            else if (state == 0)
            {
                Console.WriteLine($"Finish Id: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            builder.SetStateMachine(stateMachine);
        }
    }
}