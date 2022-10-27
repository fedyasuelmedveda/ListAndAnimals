using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    { 
        public string Name { get; }
        public abstract void SaySomething();
        public Animal(string name)
        {
            Name = name;
        }
    }
}
