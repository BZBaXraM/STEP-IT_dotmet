using FactoryMethodProduct.Abstract;

namespace FactoryMethodProduct.Concrete
{
    internal class Food : IProduct
    {
        private readonly List<string> _foodList = new List<string>()
        {
            "Хлеб",
            "Молочный шоколад Nestlé",
            "Виноград",
            "Арбуз"
        };

        public void doStuff()
        {
            Console.WriteLine("\n\n\tЯ вытускаю вот эти продукты:");
            foreach (var item in _foodList)
            {
                Console.WriteLine($"\t\t{item} ");
            }
            
        }
    }
}