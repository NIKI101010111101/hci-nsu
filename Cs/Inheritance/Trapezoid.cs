using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Trapezoid : Figura
    {
        private int A { get; set; }
        private int B { get; set; }
        private int C { get; set; }
        private int D { get; set; }

        public Trapezoid(int a, int b, int c, int d) : base("qwerty", 0)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Trapezoid() : base()
        {
            Console.WriteLine("Enter side a: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter side c: ");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter side d: ");
            D = Convert.ToInt32(Console.ReadLine());
        }

        public void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Side);
            Console.WriteLine($"{A} {B} {C} {D}");
        }
    }
}
