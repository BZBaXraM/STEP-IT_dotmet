using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorCategory : Creator
{
    public override ILibrary LibraryCreator() => new Category();
}