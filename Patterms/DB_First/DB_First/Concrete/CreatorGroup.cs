using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorGroup : Creator
{
    public override ILibrary LibraryCreator() => new Group();
}