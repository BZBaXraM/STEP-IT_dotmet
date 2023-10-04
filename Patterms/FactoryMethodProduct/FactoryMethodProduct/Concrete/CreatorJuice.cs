using FactoryMethodProduct.Abstract;

namespace FactoryMethodProduct.Concrete
{
    internal class CreatorJuice : Creator
    {
        public override IProduct CreateProduct() => new Juice();
    }
}