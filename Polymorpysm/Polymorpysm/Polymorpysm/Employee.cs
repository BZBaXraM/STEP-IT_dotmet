using System;


namespace Polymorpysm
{
    internal class Employee:Human
    {
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string FirstName, string LastName, DateTime date,double salary)
            :base(FirstName,LastName,date)
        {
            this.Salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary:     {Salary}" +
                $"\n----------------");
        }
    }
}
