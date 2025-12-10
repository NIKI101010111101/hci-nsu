namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(123);
            circle.Info();

            Square square = new Square();
            square.Info();

            Triangula triangula = new Triangula(3, 4, 5);
            triangula.Info();

            Trapezoid triangle = new Trapezoid(10, 5, 4, 4);
            triangle.Info();
        }
    }
}
