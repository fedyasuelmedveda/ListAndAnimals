using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Elephant : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("Trump!");
        }
        public Elephant(string name) : base(name,5000)
        {
            NumberOfLegs = 4;
        }
    }
}
