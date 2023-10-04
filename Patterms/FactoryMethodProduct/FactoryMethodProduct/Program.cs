using FactoryMethodProduct.Abstract;
using FactoryMethodProduct.Concrete;

namespace FactoryMethodProduct
{
    internal static class Program
    {
        static void Main()
        {
            // Creator creator = new CreatorFood();
            // IProduct product = creator.CreateProduct();
            // product.doStuff();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"1. Juice Products
2. Food Products
Any: Exit");
                Console.Write("\n\tEnter menu item number: ");
                var choice = Console.ReadKey().KeyChar;
                Creator? creator = null;
                switch (choice)
                {
                    case '1':
                        creator = new CreatorJuice();
                        break;
                    case '2':
                        creator = new CreatorFood();
                        break;
                    default:
                        creator = null;
                        break;
                }

                if (creator == null) break;
                var product = creator.CreateProduct();
                product.doStuff();
                Console.ReadLine();
            }
        }
    }
}