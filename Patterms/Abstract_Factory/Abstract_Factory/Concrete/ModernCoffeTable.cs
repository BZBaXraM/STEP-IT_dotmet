using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ModernCoffeTable : ICoffeTable
    {
        public bool HasLogs { get; set;  } = false;

        public ModernCoffeTable()
        {
            Console.WriteLine("Modern CoffeTable");
        }

        public void PutOn()
        {
            throw new NotImplementedException();
        }
    }
}