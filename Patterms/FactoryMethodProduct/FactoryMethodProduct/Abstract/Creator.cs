namespace FactoryMethodProduct.Abstract
{
    internal abstract class Creator
    {
        public void someOperation() => Console.WriteLine("SomeOperation");
        public abstract IProduct CreateProduct();
    }
}