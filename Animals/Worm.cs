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
        public override void Eat()
        {
            weightInG += 0.01;
        }
        public Worm(string name) : base(name)
        {
            numberOfLegs = 0;
            weightInG = 1;
        }
    }
}
