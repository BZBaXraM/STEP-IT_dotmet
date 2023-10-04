using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorTeacher : Creator
{
    public override ILibrary LibraryCreator() => new Teacher();
}