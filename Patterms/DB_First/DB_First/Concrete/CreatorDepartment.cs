using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorDepartment : Creator
{
    public override ILibrary LibraryCreator() => new Department();
}