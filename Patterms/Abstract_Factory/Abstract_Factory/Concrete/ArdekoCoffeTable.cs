using Abstract_Factory.Abstract;

namespace Abstract_Factory.Concrete
{
    internal class ArdekoCoffeTable : ICoffeTable
    {
        public bool HasLogs { get; set; } = true;

        public ArdekoCoffeTable()
        {
            Console.WriteLine("Ardeko Coffe");
        }
        public void PutOn()
        {
            throw new NotImplementedException();
        }
    }
}