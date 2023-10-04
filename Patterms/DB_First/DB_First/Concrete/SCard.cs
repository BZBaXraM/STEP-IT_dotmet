using System;
using System.Collections.Generic;
using DB_First.Abstract;
using DB_First.Concrete;

namespace DB_First
{
    public partial class SCard : ILibrary
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdBook { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int IdLib { get; set; }

        public virtual Book IdBookNavigation { get; set; } = null!;
        public virtual Lib IdLibNavigation { get; set; } = null!;
        public virtual Student IdStudentNavigation { get; set; } = null!;

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var sc = context.SCards.Select(x => x.IdStudent).ToList();
                foreach (var item in sc)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}