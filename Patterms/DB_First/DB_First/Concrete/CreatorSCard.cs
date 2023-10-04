using DB_First.Abstract;

namespace DB_First.Concrete;

public class CreatorSCard : Creator
{
    public override ILibrary LibraryCreator() => new SCard();
}