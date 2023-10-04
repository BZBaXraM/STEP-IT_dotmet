using Abstract_Factory.Abstract;
using Abstract_Factory.Concrete;

namespace Abstract_Factory;

class Program
{
    static void Main()
    {
        IFurnitureFactory? factory = new VictorianFactory();
        factory.CreateSofa();
        factory.CreateChair();
    }
}