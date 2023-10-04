using FactoryMethod.Abstract.Concreate;

namespace FactoryMethod.Abstract
{
    class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Truck();
    }
}