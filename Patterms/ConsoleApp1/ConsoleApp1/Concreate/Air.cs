namespace FactoryMethod.Abstract.Concreate
{
    internal class Air : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Я летаю!");
        }
    }
}