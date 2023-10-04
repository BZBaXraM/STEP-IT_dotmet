using System;
using System.Collections.Generic;
using DB_First.Abstract;

namespace DB_First
{
    public partial class Group : ILibrary
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; }
        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var group = context.Groups.Select(x => x.Name).ToList();
                foreach (var item in group)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}
