using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Cirkel : Geometri //  ärver ifrån Geometri
    {
        // Egenskaper
        private double Radius { get; }

        private double Pi { get; }


        public Cirkel(string name) : base(name)
        {
            // Fasta värden i konstruktorn
            Radius = 5;
            Pi = Math.PI;
        }

        // tvingas overrida metoden ifrån Parentclassen Geometri, klass med returntyp double
        public override double Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna : radien * radien * pi , ({Radius} x {Radius} ) * {Pi}");
            double answer = Math.Round((Radius * Radius) * Pi, 2);
            Console.Write($"Arean på vår {Name} är: {answer}, vi avrundar till 2 decimaler.\n");
            return answer;
            // Returntyp double
        }
    }
}
