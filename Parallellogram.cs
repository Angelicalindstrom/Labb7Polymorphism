using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Parallellogram : IGeometri // Ärver ifrån IGeometri
    {
        // Egenskaper
        public string Name => "Parallellogram";
        public double ParaBase { get; }
        public double ParaHeight { get; }

        // Frivilliga standardvärden i konstruktorns parameter
        public Parallellogram(double paraBase = 5.5, double paraHeight = 7.5)
        {
            ParaBase = paraBase;
            ParaHeight = paraHeight;
        }

        // Implementation av ärvd metod från IGeometri
        public void Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna Basen {ParaBase} x Höjden {ParaHeight}");
            double answer = Math.Round(ParaBase * ParaHeight, 2);
            Console.WriteLine($"Arean på vår {Name} är: {answer}.");
        }
    }
}
