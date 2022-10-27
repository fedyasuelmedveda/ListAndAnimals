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
        public override void Eat()
        {
            weightInG+=0.02;
        }
        public Lizzard(string name) : base(name) 
        {
            numberOfLegs = 4;
            weightInG = 60;
        }
    }
}
