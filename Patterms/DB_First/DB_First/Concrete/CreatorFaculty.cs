using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorFaculty : Creator
{
    public override ILibrary LibraryCreator() => new Faculty();
}