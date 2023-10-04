using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class Developer : Employee
    {
        public string?[] languages;
        public Developer()
        {
        }

        public Developer(string FirstName, string LastName, DateTime date, double salary, string[] languages) : base(FirstName, LastName, date, salary)
        {
            this.languages = languages.Clone() as string?[]??new string[1];
        }

        public override void Print()
        {
            base.Print();
        }

        public override string Think() => "Hello World";
        
    }
}
