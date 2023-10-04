using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ArdekoSofa : ISofa
    {
        public bool HasConrner { get; set; } = true;
        public bool CanOpen { get; set; } = false;

        public ArdekoSofa()
        {
            Console.WriteLine("Ardeko Sofa");
        }
        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}