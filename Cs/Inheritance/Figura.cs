using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Figura
    {
        private protected string Name { get; set; }
        private protected int Side;
        public Figura(string name, int side)
        {
            Name = name;
            Side = side;
        }

        public Figura()
        {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Side 1/0: ");
            Side = Convert.ToInt32(Console.ReadLine());
        }
    }
}
