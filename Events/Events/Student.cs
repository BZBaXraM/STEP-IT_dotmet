﻿using System;

namespace Events
{
    internal class Student:IComparable, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
      

        public object Clone()
        {
            Student tmp = (Student)this.MemberwiseClone();       
            return tmp;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student) return LastName.CompareTo((obj as Student).LastName);
            throw new NotImplementedException();
           
        }

        public override string ToString()
        {
            return $"First Name : {FirstName}\n" +
                $"Last Name: {LastName}\n" +
                $"Birthday: {BirthDate.ToShortDateString()}\n";
        }

        public void Exam(string task)
        {
            Console.WriteLine($"Student {LastName} solved the {task}");
        }

        public void Exam(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Student {LastName} solved the {e.Task}");
        }
    }
}
