using System;
using System.Collections.Generic;
using DB_First.Abstract;

namespace DB_First
{
    public partial class Student : ILibrary
    {
        public Student()
        {
            SCards = new HashSet<SCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdGroup { get; set; }
        public int Term { get; set; }

        public virtual Group IdGroupNavigation { get; set; } = null!;
        public virtual ICollection<SCard> SCards { get; set; }

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var student = context.Students.Select(x => x.FirstName).ToList();
                foreach (var item in student)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}