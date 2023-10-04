using System;
using System.Collections.Generic;
using DB_First.Abstract;

namespace DB_First
{
    public partial class Department : ILibrary
    {
        public Department()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Teacher> Teachers { get; set; }
        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var dep = context.Departments.Select(x => x.Name).ToList();
                foreach (var item in dep)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}
