using System;


namespace Iterators
{
    internal class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }

            public override string ToString()
            {
                return $"Name: {FirstName}, " +
                    $"Surname: {LastName}, " +
                    $"Birthday: {BirthDate.ToShortDateString()}";
            }
        }

        class Auditory
        {
            List<Student> auditory = new List<Student>
            {
                new Student
                {
                    FirstName = "Redmi",
                    LastName="Samsungov",
                    BirthDate = new DateTime(1685, 5, 30)
                },
                new Student
                {
                    FirstName = "Repository",
                    LastName="Githubin",
                    BirthDate = new DateTime(1925, 10, 21)
                },
                new Student
                {
                    FirstName = "Mostly",
                    LastName="Sunny",
                    BirthDate = new DateTime(1530, 3, 5)
                },
                new Student
                {
                    FirstName = "Meeting",
                    LastName="In General",
                    BirthDate = new DateTime(3446, 12, 12)
                }
            };
            public IEnumerator<Student> GetEnumerator()
            {
                for (int i = 0; i < auditory.Count; i++)
                {
                    yield return auditory[i];
                }
            }
        }

        class NamedIterator
        {
            const int LIM = 10;
            int _limit;
            public NamedIterator(int limit)
            {
                _limit = limit;
            }
            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < _limit; i++)
                {
                    if (i == LIM) yield break;
                    yield return i;
                }
            }

            public IEnumerable<int> GetRange(int start)
            {
                for (int i = start; i <= _limit; i++)
                {
                    if (i == LIM) yield break;
                    yield return i;
                }
            }
        }
        static void Main(string[] args)
        {
            //Auditory auditory = new Auditory();
            //Console.WriteLine("List of stdents");
            //foreach (Student student in auditory)
            //{
            //    Console.WriteLine(student);
            //}


            Console.WriteLine("Enter start: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            NamedIterator iterator = new NamedIterator(end);

            Console.WriteLine("All: ");
            foreach (int item in iterator)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine("Range: ");
            foreach (int item in iterator.GetRange(start))
            {
                Console.WriteLine($"{item} ");
            }

        }
    }
}