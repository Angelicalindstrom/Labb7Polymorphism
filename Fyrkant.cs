using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Fyrkant: IGeometri // Ärver ifrån IGeometri
    {
        // Egenskaper
        public string Name => "Fyrkant";
        public double SquareSide { get; }
        
        // Frivilligt standardvärde i konstruktorns parameter
        public Fyrkant(double squareSide = 4)
        {
            SquareSide = squareSide;
        }

        // Implementation av ärvd metod från IGeometri
        public void Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi multiplicera en sida x 2, ({SquareSide} x {SquareSide})");
            double answer = Math.Round(SquareSide * SquareSide, 2);
            Console.WriteLine($"Arean på vår {Name} är: {answer}");
        }
    }
}
