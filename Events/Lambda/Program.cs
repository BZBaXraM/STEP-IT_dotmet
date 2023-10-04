using System;

namespace Lambda
{
    internal class Program
    {
        public delegate double AnnoDelegDouble(double x, double y);
        public delegate void AnnoDelegInt(int x);
        public delegate void AnnoDelegVoid();
        class Dispacher
        {
            public event AnnoDelegInt eventVoid;
            public event AnnoDelegDouble eventDouble;
            public double OnEventDouble(double x, double y)
            {
                if (eventDouble != null) return eventDouble(x, y);
                throw new NullReferenceException();
            }
            public void OnEventVoid(int n = 0)
            {
                if (eventVoid != null) eventVoid(n);
            }
        }
        static void Main()
        {
            // (parameters) => {method_body}
            Dispacher dispacher = new Dispacher();

            dispacher.eventDouble +=
                (double x, double y) =>
                {
                    if (y != 0)
                    {
                        return x / y;
                    }
                    throw new DivideByZeroException();
                };
            double numb1 = 26.456, numb2 = 12.54;
            Console.WriteLine($"{numb1} / {numb2} = " +
                $"{dispacher.OnEventDouble(numb1, numb2)}");

            AnnoDelegVoid delegVoid = new AnnoDelegVoid(() => { Console.WriteLine("hell0"); });
            delegVoid += () => { Console.WriteLine("gooDbYE"); };
            delegVoid();

            // List, ArrayList, Stack, Queue, Hashtable, SortedList
            // generics
        }
    }
}
