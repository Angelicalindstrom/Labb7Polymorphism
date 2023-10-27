using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Rektangel : IGeometri // Ärver ifrån IGeometri
    {
        // Egenskaper
        public string Name => "Rektangel"; // Implementation av ärvd egenskap från IGeometri
        public double RekBase { get; }
        public double RekHeight { get; }

        // Frivilliga standardvärden i konstruktorns parameter
        public Rektangel(double rekBase = 5.5, double rekHeight = 11.5)
        {
            RekBase = rekBase;
            RekHeight = rekHeight;
            
        }

        // Implementation av ärvd metod från IGeometri
        public void Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"För att räkna ut Arean av en {Name} måste vi multiplicera basen {RekBase} med höjden {RekHeight}");
            double answer = Math.Round(RekBase * RekHeight, 2);
            Console.WriteLine($"Arean på vår {Name} är: {answer}");
        }

    }
}
