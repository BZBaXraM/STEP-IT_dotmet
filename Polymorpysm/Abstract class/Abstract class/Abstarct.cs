using System;


namespace Abstract_class
{
    abstract class Animal
    {
        public abstract void voice();
    }

    class Dog : Animal
    {
        public override void voice()
        {
            Console.WriteLine("GAV");
        }
    }

    class Cat : Animal
    {
        public override void voice()
        {
            Console.WriteLine("MEW");
        }
    }
    class Abstract
    {
        static void Main(string[] args)
        {

            Developer developer = new Developer
                                  (
                                   "Bill",
                                   "Gates",
                                   new DateTime(1955, 10, 28),
                                   230,
                                   new string[] { "C++", "C#", "Java"}                                                 
                                                 );
            Console.WriteLine(developer.Think());

        }
    }
}
