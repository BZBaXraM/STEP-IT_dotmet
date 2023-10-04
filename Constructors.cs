using System;

namespace Constructors
{   
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            Student student2 = new("Nadir", "Zamanov", "FBAS_2212_ru", 42);
            Student student3 = new("Salam", "Salamzade", 40);
            Student student4 = new(
                groupName: "FBAS_2212_ru",
                name: "Ali",
                surname: "Aliyev",
                age: 23);
            student.ShowInfo();
            student2.ShowInfo();
            student3.ShowInfo();
            student3.ShowInfo();
            student4.ShowInfo();

            //ClassA a = new ();
            //ClassB b = new ();
            //a.MethodA(b);

        }
    }
    class Student
    {
        private int StudentId;
        private string name;
        private string surName;
        private string groupName;
        private int age;
        private static int Id;

        static Student() 
        {
            Id = 0;
        }
        public Student() : this("John", "Doe", 18)
        {

        }
        public Student(string name, string surname, int age)
            : this(name, surname, "Empty", age)
        {
        }
        public Student(string name, string surname, string groupName, int age)
        {
            Id++;
            StudentId = Id;
            this.name = name;
            this.surName = surname;
            this.groupName = groupName;
            if (age > 0) this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Id:\t\t{StudentId}\n" +
                $"Name:\t\t{name}\n" +
                $"Surname:\t{surName}\n" +
                $"Group name:\t{groupName}\n" +
                $"Age:\t\t{age}");
            Console.WriteLine(new string('-', 25));
        }

    }

    public class ClassA
    {
        public void MethodA(ClassB objB) 
        {
            objB.MethodB(this);
        }
    }
    public class ClassB
    {
        public void MethodB(ClassA objA) 
        {
            Console.WriteLine(objA.GetType().Name);
        }
    }
}
