using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorPress : Creator
{
    public override ILibrary LibraryCreator() => new Press();
}