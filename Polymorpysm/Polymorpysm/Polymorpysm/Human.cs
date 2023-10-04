using System;


namespace Polymorpysm
{
    internal class Human
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Human()
        {

        }

        public Human(string FirstName, string LastName,DateTime date)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = date;
        }

        public virtual void Print()
        {
            Console.WriteLine($"" +
                $"FirstName:  {FirstName}" +
                $"\nLastName:   {LastName}" +
                $"\nBirthDay:   {BirthDate.ToShortDateString()}");
        }


    }
}
