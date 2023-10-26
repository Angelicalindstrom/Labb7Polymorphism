namespace Labb7Polymorphism
{// Angelica Lindström NET.23
    internal class Program
    {
        static void Main(string[] args)
        {

            Geometri MyRektangle = new Rektangel("rektangel");
            MyRektangle.Area();

            Geometri MySquare = new Fyrkant("Fyrkant");
            MySquare.Area();

            Geometri MyCirkle = new Cirkel("Cirkel");
            MyCirkle.Area();

            Geometri MyParallellogram = new Parallellogram("Paralellogram");
            MyParallellogram.Area();

            Geometri MyEllips = new Ellips("Ellips");
            MyEllips.Area();

        }
    }
}