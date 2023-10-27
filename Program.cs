namespace Labb7Polymorphism
{// Angelica Lindström NET.23
    internal class Program
    {
        static void Main(string[] args)
        {

            IGeometri myRectangle = new Rektangel();
            myRectangle.Area();

            IGeometri mySquare = new Fyrkant();
            mySquare.Area();

            IGeometri myCircle = new Cirkel();
            myCircle.Area();

            IGeometri myParallellogram = new Parallellogram();
            myParallellogram.Area();

            IGeometri myEllips = new Ellips();
            myEllips.Area();

        }
    }
}