using System;

namespace MathLibrary
{
    public static class MathClass
    {
        public static double plus(params string[] a)
        {
            double result = 0;

            foreach (string s in a)
            {
                result += Double.Parse(s);
            }

            return result;
        }
        public static double minus(params string[] a)
        {
            double result = Double.Parse(a[0]);
            a[0] = "0";
            foreach (string s in a)
            {
                result -= Double.Parse(s);
            }

            return result;
        }
        public static double multiplication(params string[] a)
        {
            double result = 1;
            foreach (string s in a)
            {
                result *= Double.Parse(s);
            }
            return result;
        }
        public static double division(params string[] a)
        {
            return Double.Parse(a[0]) / Double.Parse(a[1]);
        }
        public static double percent(params string[] a)
        {
            return Double.Parse(a[0]) % Double.Parse(a[1]);
        }
        public static double pow(params string[] a)
        {
            return Math.Pow(Double.Parse(a[0]), Double.Parse(a[1]));
        }
    }
}
