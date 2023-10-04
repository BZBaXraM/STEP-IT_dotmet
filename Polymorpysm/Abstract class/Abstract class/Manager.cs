using System;


namespace Abstract_class
{
    internal class Manager : Employee
    {
        public string? FieldActivity { get; set; }

        public Manager(string FirstName, string LastName, DateTime date, double salary, string fieldActivity)
            : base(FirstName, LastName, date, salary)
        {
            this.FieldActivity = fieldActivity;
        }

        //public void ShowManager()
        //{
        //    base.Print();
        //    Console.WriteLine($"FieldActivity:      {FieldActivity}" +
        //        $"\n----------------");
        //}
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"FieldActivity:      {FieldActivity}" +
                                $"\n----------------");
        }

        public override string Think() => "I think about employees";

    }
}
