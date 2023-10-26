using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Fyrkant: Geometri //  ärver ifrån Geometri
    {
        // Egenskaper
        private double SquareSide { get; }
        
        public Fyrkant(string name) : base(name)
        {
            // Fasta värden i konstruktorn
            SquareSide = 4;
        }

        // tvingas overrida metoden ifrån Parentclassen Geometri, klass med returntyp double
        public override double Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi multiplicera en sida x 2, ({SquareSide} x {SquareSide})");
            double answer = Math.Round(SquareSide * SquareSide, 2);
            Console.Write($"Arean på vår {Name} är: {answer}\n");
            return answer;
            // Returntyp double
        }
    }
}
