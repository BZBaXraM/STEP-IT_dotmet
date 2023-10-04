using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorStudent : Creator
{
    public override ILibrary LibraryCreator() => new Student();
}