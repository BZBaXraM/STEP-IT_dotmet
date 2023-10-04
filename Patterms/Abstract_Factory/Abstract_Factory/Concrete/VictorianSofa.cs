using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class VictorianSofa : ISofa
    {
        public bool HasConrner { get; set; } = true;
        public bool CanOpen { get; set; } = false;

        public VictorianSofa()
        {
            Console.WriteLine("Sofa");
        }

        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}