using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Parallellogram : Geometri //  ärver ifrån Geometri
    {
        // Egenskaper
        private double ParaBase{ get; }

        private double ParaHeight { get; }


        public Parallellogram(string name) : base(name)
        {
            // Fasta värden i konstruktorn
            ParaBase = 5.5;
            ParaHeight = 7.5;
        }


        // tvingas overrida metoden ifrån Parentclassen Geometri, klass med returntyp double
        public override double Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna Basen {ParaBase} x Höjden {ParaHeight}");
            double answer = Math.Round(ParaBase * ParaHeight, 2);
            Console.Write($"Arean på vår {Name} är: {answer}.\n");
            return answer;
            // Returntyp double
        }
    }
}
