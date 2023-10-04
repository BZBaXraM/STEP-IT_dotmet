using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorTCard : Creator
{
    public override ILibrary LibraryCreator() => new TCard();
}