using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ICoffeTable CreateCoffeTable() => new ModernCoffeTable();

        public ISofa CreateSofa() => new ModernSofa();
    }
}