using System;
using System.Collections.Generic;
using DB_First.Abstract;
using DB_First.Concrete;

namespace DB_First
{
    public partial class TCard : ILibrary
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdBook { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int IdLib { get; set; }

        public virtual Book IdBookNavigation { get; set; } = null!;
        public virtual Lib IdLibNavigation { get; set; } = null!;
        public virtual Teacher IdTeacherNavigation { get; set; } = null!;

        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var tc = context.TCards.Select(x => x.IdBook).ToList();
                foreach (var item in tc)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}