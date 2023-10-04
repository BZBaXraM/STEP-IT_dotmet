using System;
using System.Text;

namespace Classes
{
    struct Point
    {
        int x;
        int y;
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void Show()
        {
            Console.WriteLine($"x = {x} y = {y}");
        }

    }

    class Student
    {
        // private - данные доступны только методом класса и вложенным классам
        // protected - данные доступны только методом класса и вложенным классам или дочерних классах 
        // internal - данные доступны только в методах текущей сборки
        // protected internal - данные доступны только в методах текущей сборки или дочерних классах
        // public - данные доступны всем методам во всех сборках

        // const
        // static
        // readonly
        string Name;
        string Surname;
        int Age;
        const double cooficient = 6.63;
        static int count = 0;
        public readonly double test_result;
        public Student(string name, string surname, int age, double result)
        {
            Name = name;
            Surname = surname;
            Age = age;
            test_result = result;
            count++;
        }
        public static int GetCount()
        {
            return count;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:\t\t{Name}\nSurname:\t{Surname}\nAge:\t\t{Age}\n");
        }
    }
    class Class_
    {
        static void Main(string[] args)
        {
            //Point point = new Point(25, 36);
            //point.Show();
            //Point point1 = new Point();
            //point1 = point;
            //point1.Show();

            Student student = new Student("Nadir", "Zamanov", 42, 95.2);
            student.ShowInfo();
            Console.WriteLine(Student.GetCount());
        }
    }
}
