using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ArdekoChair : IChair
    {
        public bool HasLogs { get; set; } = true;

        public ArdekoChair()
        {
            Console.WriteLine("ArdekoChair");
        }
        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}