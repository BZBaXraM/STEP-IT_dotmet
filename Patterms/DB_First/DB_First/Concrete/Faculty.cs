using System;
using System.Collections.Generic;
using DB_First.Abstract;

namespace DB_First
{
    public partial class Faculty : ILibrary
    {
        public Faculty()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var facul = context.Faculties.Select(x => x.Name).ToList();
                foreach (var item in facul)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}