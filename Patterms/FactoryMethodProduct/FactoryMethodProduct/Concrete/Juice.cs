using FactoryMethodProduct.Abstract;

namespace FactoryMethodProduct.Concrete
{
    internal class Juice : IProduct
    {
        readonly List<string> _juiceList = new List<string>()
        {
            "Coca Cola",
            "Fanta",
            "Sprite"
        };
        public void doStuff()
        {
            Console.WriteLine("\n\n\tЯ выпускаю вот эти соки:");
            foreach (var item in _juiceList)
            {
                Console.WriteLine($"\t\t{item} ");
            }
        }
    }
}