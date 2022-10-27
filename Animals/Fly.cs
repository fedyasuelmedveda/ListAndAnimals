﻿using System;
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
        public Fly(string name) : base(name,0.00002) 
        {
            NumberOfLegs = 6;
        }
    }
}
