using System;


namespace Abstract_class
{
    internal class Scientist : Employee
    {
        public string? ScienticDirection { get; set; }

        public Scientist(string FirstName, string LastName, DateTime date, double salary, string ScienticDirection)
           : base(FirstName, LastName, date, salary)
        {
            this.ScienticDirection = ScienticDirection;
        }

        //public void ShowScientist()
        //{
        //    base.Print();
        //    Console.WriteLine($"ScienticDirection:      {ScienticDirection}" +
        //        $"\n----------------");
        //}
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ScienticDirection:      {ScienticDirection}" +
                $"\n----------------");
        }

        public override string Think() => "I'm genius. I think about galaxy.";
      
    }

}

