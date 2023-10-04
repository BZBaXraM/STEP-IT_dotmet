using System;


namespace Anonym_methods
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

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The use of events:");
            Dispacher dispacher = new Dispacher();

            dispacher.eventDouble +=
                delegate (double x, double y)
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

            int number = 31;
            dispacher.eventVoid +=
                delegate (int x)
                {
                    Console.WriteLine($"{number} + {x} = " +
                        $"{number + x}");
                };
            dispacher.OnEventVoid(69);

            AnnoDelegVoid delegVoid =
                new AnnoDelegVoid(delegate { Console.WriteLine("Hello"); });

            delegVoid += delegate { Console.WriteLine("Goodbye"); };
            delegVoid();
        }
    }
}
