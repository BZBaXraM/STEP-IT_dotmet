namespace FactoryMethod.Abstract.Concreate
{
    internal class Ship : ITransport 
    {
        public void Deliver()
        {
            Console.WriteLine("Я доставляю по воде!");
        }
    }
}