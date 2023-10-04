using System;


namespace LINQ_To_Object
{
    internal class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public int GroupId { get; set; }
            public override string ToString()
            {
                return $"Name: {FirstName}, " +
                    $"Surname: {LastName}, " +
                    $"Birthday: {BirthDate.ToShortDateString()}";
            }
        }

        class Group
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void show(IEnumerable<int> query)
        {
            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            // LINQ to Object

            int[] arr = { 145, 342, 23, 34, 565, 86, 682 };
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Redmi",
                    LastName="Samsungov",
                    BirthDate = new DateTime(1685, 5, 30),
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Repository",
                    LastName="Githubin",
                    BirthDate = new DateTime(1925, 10, 21),
                    GroupId = 2
                },
                new Student
                {
                    FirstName = "Mostly",
                    LastName="Sunny",
                    BirthDate = new DateTime(1530, 3, 5),
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Meeting",
                    LastName="In General",
                    BirthDate = new DateTime(3446, 12, 12),
                    GroupId = 3
                },

                 new Student
                {
                    FirstName = "Mike",
                    LastName="Vazovski",
                    BirthDate = new DateTime(2010, 12, 12),
                    GroupId = 3
                }
            };


            List<Group> groups = new List<Group>
        {
            new Group { Id = 1, Name ="2212"},
            new Group { Id = 2, Name ="2211"},
            new Group { Id = 3, Name ="Chingiskhan group"}
        };

            #region from select
            IEnumerable<int> que = from i in arr select i;
            //Console.WriteLine("Array query before change: ");
            //foreach (var item in que)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("To array before change: ");
            //var arr2 = que.ToArray();
            //foreach (var item in arr2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //arr[0] = 32;

            //Console.WriteLine("Array query after change: ");
            //foreach (var item in que)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("To array before change: ");
            //foreach (var item in arr2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region where
            //que = from i in arr
            //      where i % 2 == 0
            //      select i;
            //show(que);
            //arr[0] = 22;
            //show(que);
            #endregion

            #region orderby (ascending, descending)
            //que = from i in arr
            //      where i % 2 == 0
            //      orderby i descending
            //      select i;
            //show(que);
            #endregion

            #region group
            IEnumerable<IGrouping<int, int>> grouping = from i in arr
                                                        group i by i % 10;
            //foreach (IGrouping<int, int> item in grouping)
            //{
            //    Console.Write($"Key: {item.Key}\nValue");
            //    foreach (int val in item)
            //    {
            //        Console.Write($"\t{val}");
            //    }
            //    Console.WriteLine();
            //}

            //grouping = from i in arr
            //           group i by i % 10 into res
            //           where res.Count() > 1
            //           select res;                       ;
            //foreach (IGrouping<int, int> item in grouping)
            //{
            //    Console.Write($"Key: {item.Key}\nValue");
            //    foreach (int val in item)
            //    {
            //        Console.Write($"\t{val}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region let

            //string[] lipsum =
            //    {
            //    "Lorem ipsum dolor sit amet, consectetur adipiscing elit,",
            //    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            //    "Ut enim ad minim veniam, quis nostrud exercitation ullamco",
            //    "laboris nisi ut aliquip ex ea commodo consequat.",
            //    "Duis aute irure dolor in reprehenderit in voluptate velit",
            //    "esse cillum dolore eu fugiat nulla pariatur."
            //    };

            //IEnumerable<string> queryLipsum = from l in lipsum
            //                                  let words = l.Split(' ', ',')
            //                                  from word in words
            //                                  where word.Count() > 5
            //                                  select word;
            //Console.WriteLine("Words, in which more than 5 characters");
            //foreach (var item in queryLipsum)
            //{
            //    Console.WriteLine($"\t{item}");
            //}
            #endregion

            #region join
            //    IEnumerable<Student> studentQuery = from g in groups
            //                                        join s in students on g.Id equals s.GroupId into res
            //                                        from r in res
            //                                        select r;

            //    Console.WriteLine("Students in groups: ");
            //    foreach (var item in studentQuery)
            //    {
            //        Console.WriteLine($"Surname: {item.LastName}\n" +
            //            $"Name: {item.FirstName}\n" +
            //            $"Group: {groups.First(g=>g.Id == item.GroupId).Name}\n");
            //    }
            #endregion


            const double daysOfYear = 365.25;
            Console.WriteLine($"The current date{DateTime.Now.ToLongDateString()}\n");

            //var quer = from s in students
            //           where (DateTime.Now - s.BirthDate).Days / daysOfYear > 20
            //           select s;
            //Console.WriteLine("\t Students older than 20 years");
            //foreach (var item in quer)
            //{
            //    Console.WriteLine(item);
            //}

            //var quer2 = students.Where(s => (DateTime.Now - s.BirthDate).Days / daysOfYear > 20)
            //    .Select(s => s);
            //Console.WriteLine();
            //foreach (var item in quer2)
            //{
            //    Console.WriteLine(item);
            //}


            var minAge = (from s in students select s)
                        .Min(s=>(DateTime.Now - s.BirthDate).Days / daysOfYear);

            Console.WriteLine(minAge);
        }

    }
}
