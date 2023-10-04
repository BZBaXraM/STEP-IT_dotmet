using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorAuthor : Creator
{
    public override ILibrary LibraryCreator() => new Author();
}