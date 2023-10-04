using Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Concrete
{
    internal class VictorianCoffeTable : ICoffeTable
    {
        public bool HasLogs { get; set; } = true;

        public VictorianCoffeTable()
        {
            Console.WriteLine("CoffeTable");
        }
        public void PutOn()
        {
            throw new NotImplementedException();
        }
    }
}
