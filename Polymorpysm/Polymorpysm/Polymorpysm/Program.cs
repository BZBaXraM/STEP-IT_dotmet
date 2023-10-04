using System;


namespace Polymorpysm
{
    class Animal
    {
        public virtual void voice()
        {
            Console.WriteLine("some voice");
        }
    }

    class Dog : Animal
    {
        public override void voice()
        {
            Console.WriteLine("Gav");
        }
    }

    class Cat : Animal
    {
        public override void voice()
        {
            Console.WriteLine("Mew");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //Dog dog = new Dog();
            //Animal barsik = new Dog();
            //Animal Pupsik = new Cat();

            //barsik.voice();
            //Pupsik.voice();
            Employee manager = new Manager("John", "Doe", new DateTime(1995, 7, 23), 2100, "IT товары");
            Manager m = new Manager("John", "Doe", new DateTime(1995, 7, 23), 2100, "IT товары");
            Employee[] employees =
            {
                manager,
                new Scientist(
                    "Albert",
                    "Einstein",
                    new DateTime(1875, 3, 14),
                    3500,
                    "Nuclear Pysisc"
                    ),
                new Manager(
                    "Victor",
                    "Lustig",
                    new DateTime(1890,1,4),
                    0,
                    "Eifel tower"
                    )
            };

            foreach (Employee item in employees)
            {
                item.Print();
                Console.WriteLine();
            }
        }
    }
}