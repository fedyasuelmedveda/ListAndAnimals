using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Lizzard : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("Hello, I'm lizzard.");
        }
        public Lizzard(string name) : base(name,0.05) 
        {
            NumberOfLegs = 4;
        }
    }
}
