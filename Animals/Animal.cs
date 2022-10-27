using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected int numberOfLegs;
        protected double weightInG;
        public string Name { get; }
        public abstract void SaySomething();
        public abstract void Eat();
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
        public double GetWeightInG()
        {
            return weightInG;
        }
        public Animal(string name)
        {
            Name = name;
        }
    }
}
