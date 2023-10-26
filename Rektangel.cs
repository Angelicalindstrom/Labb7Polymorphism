using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Rektangel : Geometri //  ärver ifrån Geometri
    {
        // Egenskaper
        private double RekBase { get; }
        private double RekHeight { get; }

        
        public Rektangel(string name) : base (name)
        {
            // Fasta värden i konstruktorn
            RekBase = 5.5;
            RekHeight = 11.5;
            
        }

        // tvingas overrida metoden ifrån Parentclassen Geometri, klass med returntyp double
        public override double Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"För att räkna ut Arean av en {Name} måste vi multiplicera basen {RekBase} med höjden {RekHeight}");
            double answer = Math.Round(RekBase * RekHeight , 2);
            Console.Write($"Arean på vår {Name} är: {answer}\n");
            return answer;
            // Returntyp double
        }

    }
}
