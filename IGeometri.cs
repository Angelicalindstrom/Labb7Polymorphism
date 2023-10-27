using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    public interface IGeometri // parentClass
    {
        // Interfacets kontrakt säger att ärvda klasser måste implementera följande:
        public string Name { get; }
        public void Area();
    }
}
