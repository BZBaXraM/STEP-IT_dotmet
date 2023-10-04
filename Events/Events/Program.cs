using System;


namespace Events
{
    public delegate void ExamDelegate(string task);

    internal class Program
    {
        static List<Student> students = new List<Student>()
            {
            new Student
            {
                FirstName = "Anjelina",
                LastName ="Jolie",
                BirthDate = new DateTime(1975, 6, 4)

            },
            new Student
            {
                FirstName = "Johny",
                LastName ="Depp",
                BirthDate = new DateTime(1963, 6, 9)
            },
            new Student
            {
                FirstName = "Kim",
                LastName = "Sokchin",
                BirthDate = new DateTime(1992, 12, 4)

            },
            new Student
            {
                FirstName = "Monika",
                LastName ="Bellucci",
                BirthDate = new DateTime(1964, 9 , 30)

            },
            new Student
            {
                FirstName = "Nadir",
                LastName ="Zamanov",
                BirthDate = new DateTime(1980, 10,7 )
            }
            ,
            new Student
            {
                FirstName = "Nadira",
                LastName ="Zamanova",
                BirthDate = new DateTime(1980, 10,8 )
            }
        };
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            //foreach (Student student in students)
            //{
            //    teacher.examEvent += student.Exam;
            //}
            //teacher.Exam("C# exam");

            // EventHandler<T>
            //foreach (Student student in students)
            //{
            //    teacher.examEventHandler += student.Exam;
            //}
            //ExamEventArgs eventArgs = new ExamEventArgs() { Task = "Task"};
            //teacher.Exam(eventArgs);

            foreach (Student student in students)
            {
                teacher.myExamEvent+= student.Exam;
            }
            teacher.ExamRand("C# exam");

        }
    }
}
