namespace FactoryMethod.Abstract
{
    internal abstract class Logistics
    {
        public void PlanDelivery() => Console.WriteLine("PlanDelivery");
        public abstract ITransport CreateTransport();
    }
}