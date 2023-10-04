using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ModernChair : IChair
    {
        public bool HasLogs { get; set; } = true;

        public ModernChair() 
        {
            Console.WriteLine("Modern Chair");
        }
        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}