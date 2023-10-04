using Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Concrete
{
    internal class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
