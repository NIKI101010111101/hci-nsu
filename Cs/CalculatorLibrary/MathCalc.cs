
using System.Windows.Navigation;
namespace CalculatorLibrary
{
    public static class MathCalc
    {
        private static int Sum(int x, int y) => x + y;
        private static int Minus(int x, int y) => x - y;
        private static double Del(int  x, int y) => x / y;
        private static int Umnog(int x, int y) => x * y;
        private static int Squar(int x) => x * x;
        private static double Sqrt(int x) => Math.Sqrt(x);

    }

}
