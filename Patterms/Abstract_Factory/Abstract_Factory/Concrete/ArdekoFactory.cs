using Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Concrete
{
    internal class ArdekoFactory : IFurnitureFactory
    {
        public bool HasLogs { get; set; } = true;
        public bool CanOpen { get; set; } = false;

        public IChair CreateChair() => new ArdekoChair();

        public ICoffeTable CreateCoffeTable() => new ArdekoCoffeTable();

        public ISofa CreateSofa() => new ArdekoSofa();
    }
}