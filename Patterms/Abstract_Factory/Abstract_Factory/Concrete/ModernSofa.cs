using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ModernSofa : ISofa
    {
        public bool HasConrner { get; set; } = true;
        public bool CanOpen { get; set; } = false;

        public ModernSofa()
        {
            Console.WriteLine("Modern Sofa");
        }

        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}