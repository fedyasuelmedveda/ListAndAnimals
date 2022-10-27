using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected int NumberOfLegs;
        public double WeightInKg { get; }
        public string Name { get; }
        public abstract void SaySomething();
        public int HowManyLegsDoYouHave()
        {
            return NumberOfLegs;
        }
        public Animal(string name, double weight)
        {
            Name = name;
            WeightInKg = weight;
        }
    }
}
