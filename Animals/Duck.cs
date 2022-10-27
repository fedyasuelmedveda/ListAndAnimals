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
        public Duck(string name) : base(name) { }
    }
}
