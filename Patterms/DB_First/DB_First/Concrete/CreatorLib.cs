using DB_First.Abstract;

namespace DB_First.Concrete;

public class CreatorLib : Creator
{
    public override ILibrary LibraryCreator() => new Lib();
}