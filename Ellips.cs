using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb7Polymorphism
{ // Angelica Lindström NET.23
    internal class Ellips : Geometri // ärver ifrån Geometri
    {
        // Egenskaper
        private double RadiusA { get; }

        private double RadiusB { get; }

        private double Pi { get; }


        public Ellips(string name) : base (name)
        {
            // Fasta värden i konstruktorn
            RadiusA = 13.43;
            RadiusB = 9.21223;
            Pi = Math.PI;
        }


        // tvingas overrida metoden ifrån Parentclassen Geometri, klass med returntyp double
        public override double Area()
        {
            // Nytt räknesätt
            Console.WriteLine($"\nFör att räkna ut Arean av en {Name} måste vi räkna :  pi {Pi} * RadieA {RadiusA} * RadieB {RadiusB}");
            double answer = Math.Round((Pi * RadiusA * RadiusB), 2);
            Console.Write($"Arean på vår {Name} är: {answer}, vi avrundar till 2 decimaler.\n");
            return answer;
            // Returntyp double
        }
    }
}
