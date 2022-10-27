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
        public override void Eat()
        {
            weightInG+=5000;
        }
        public Elephant(string name) : base(name)
        {
            numberOfLegs = 4;
            weightInG = 5000000;
        }
    }
}
