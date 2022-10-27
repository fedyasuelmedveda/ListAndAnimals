using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Fly : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("Bzzzz!");
        }
        public override void Eat()
        {
            weightInG += 0.0005;
        }
        public Fly(string name) : base(name) 
        {
            numberOfLegs = 6;
            weightInG = 0.02;
        }
    }
}
