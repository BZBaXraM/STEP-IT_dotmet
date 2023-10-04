using System;
using System.Collections.Generic;
using DB_First.Abstract;

namespace DB_First
{
    public partial class Teacher : ILibrary
    {
        public Teacher()
        {
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdDep { get; set; }

        public virtual Department IdDepNavigation { get; set; } = null!;
        public virtual ICollection<TCard> TCards { get; set; }

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var teacher = context.Teachers.Select(x => x.FirstName).ToList();
                foreach (var item in teacher)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}