using DB_First.Abstract;

namespace DB_First.Concrete;

public partial class Author : ILibrary
{
    public Author()
    {
        Books = new HashSet<Book>();
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; }
    public void CreateLib()
    {
        using (LibraryContext context = new LibraryContext())
        {
            var authors = context.Authors.Select(x => x.FirstName).ToList();
            foreach (var item in authors)
            {
                Console.WriteLine($"\t\t{item} ");
            }
        }
    }
}