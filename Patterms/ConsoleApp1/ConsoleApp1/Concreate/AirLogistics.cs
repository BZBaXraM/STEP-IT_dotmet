namespace FactoryMethod.Abstract.Concreate
{
    internal class AirLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Air();
        }
    }
}
