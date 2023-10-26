using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    public abstract class Geometri // parentClass
    {
        public string Name { get; set; }

        // Abstract klass med returntyp double
        public abstract double Area();
        
        public Geometri(string name) 
        {
            Name = name;
        }
    }
}
