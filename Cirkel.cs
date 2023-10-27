using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Cirkel : IGeometri // Ärver ifrån IGeometri
    {
        // Egenskaper
        public string Name => "Cirkel";
        public double Radius { get; }

        // Frivilligt standardvärde i konstruktorns parameter
        public Cirkel(double radius = 5)
        {
            Radius = radius;
        }

        // Implementation av ärvd metod från IGeometri
        public void Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna : radien * radien * pi, ({Radius} x {Radius}) * {Math.PI}");
            double answer = Math.Round(Radius * Radius * Math.PI, 2);
            Console.WriteLine($"Arean på vår {Name} är: {answer}, vi avrundar till 2 decimaler.");
        }
    }
}
