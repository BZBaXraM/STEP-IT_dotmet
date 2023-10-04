using DB_First.Abstract;

namespace DB_First.Concrete;

internal class CreatorTheme : Creator
{
    public override ILibrary LibraryCreator() => new Theme();
}