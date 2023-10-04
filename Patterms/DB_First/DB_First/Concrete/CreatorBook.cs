using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorBook : Creator
{
    public override ILibrary LibraryCreator() => new Book();
}