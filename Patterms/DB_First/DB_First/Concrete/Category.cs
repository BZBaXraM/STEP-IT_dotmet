using System;
using System.Collections.Generic;
using DB_First.Abstract;
using DB_First.Concrete;

namespace DB_First
{
    public partial class Category : ILibrary
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Book> Books { get; set; }

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var category = context.Categories.Select(x => x.Name).ToList();
                foreach (var item in category)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}