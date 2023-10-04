using System;


namespace Polymorpysm
{
    internal sealed class Student: Human //// sealed zaprechaet nasledovat
    {
        
        public string? GroupName { get; set; }
        public new string? FirstName { get; set; }


        public Student()
        {

        }



        public Student(string FirstName, string LastName, DateTime date, string GroupName) 
            :base(FirstName,LastName,date)
        {
           
            this.GroupName = GroupName;

        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Group:      {GroupName}" +
                $"\n---------------------------");
        }

    }



   
}
