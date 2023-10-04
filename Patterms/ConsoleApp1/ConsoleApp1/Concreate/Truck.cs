namespace FactoryMethod.Abstract.Concreate
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Я доставляю по суще!");
        }
    }
}
