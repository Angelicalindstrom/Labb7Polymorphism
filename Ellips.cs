using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Ellips : IGeometri // Ärver ifrån IGeometri
    {
        // Egenskaper
        public string Name => "Ellips";
        public double RadiusA { get; }
        public double RadiusB { get; }


        // Frivilliga standardvärden i konstruktorns parameter
        public Ellips(double radiusA = 13.43, double radiusB = 9.21223)
        {
            RadiusA = radiusA;
            RadiusB = radiusB;
        }


        // Implementation av ärvd metod från IGeometri
        public void Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna : pi {Math.PI} * RadieA {RadiusA} * RadieB {RadiusB}");
            double answer = Math.Round(Math.PI * RadiusA * RadiusB, 2);
            Console.WriteLine($"Arean på vår {Name} är: {answer}, vi avrundar till 2 decimaler.");
        }
    }
}
