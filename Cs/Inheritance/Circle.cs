using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Circle : Figura
    {
        private int R { get; set; }
        public Circle(int r) : base("qwerty", 0)
        {
            R = r;
        }

        public Circle() : base()
        {
            Console.WriteLine("Enter Radius: ");
            R = Convert.ToInt32(Console.ReadLine());
        }

        public void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Side);
            Console.WriteLine(R);
        }
    }
}
