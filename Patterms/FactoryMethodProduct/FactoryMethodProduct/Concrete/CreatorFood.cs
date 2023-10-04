using FactoryMethodProduct.Abstract;

namespace FactoryMethodProduct.Concrete
{
    internal class CreatorFood : Creator
    {
        public override IProduct CreateProduct() => new Food();
    }
}