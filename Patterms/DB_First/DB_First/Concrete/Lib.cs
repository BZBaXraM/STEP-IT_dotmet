using DB_First.Abstract;

namespace DB_First
{
    public partial class Lib : ILibrary
    {
        public Lib()
        {
            SCards = new HashSet<SCard>();
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<SCard> SCards { get; set; }
        public virtual ICollection<TCard> TCards { get; set; }
        public void CreateLib()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var lib = context.Libs.Select(x => x.FirstName).ToList();
                foreach (var item in lib)
                {
                    Console.WriteLine($"\t\t{item} ");
                }
            }
        }
    }
}
