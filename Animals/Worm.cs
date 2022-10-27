using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Worm: Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("...");
        }
        public Worm(string name) : base(name, 0.0001)
        {
            NumberOfLegs = 0;
        }
    }
}
