using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Duck : Animal 
    {
        public override void SaySomething()
        {
            Console.WriteLine("Crya!");
        }

        public override void Eat()
        {
            weightInG += 50;
        }
        public Duck(string name) : base(name) 
        {
            numberOfLegs = 2;
            weightInG = 1000;
        }
    }
}
