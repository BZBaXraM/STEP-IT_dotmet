using Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Concrete
{
    internal class VictorianChair : IChair
    {
        public bool HasLogs { get; set; }

        public VictorianChair()
        {
            Console.WriteLine("Victorian Chair");
        }

        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}
