using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndOperatorOverloading
{
    internal class Path
    {
        private string A;
        private string B;
        private int Len;
        public Path(string a, string b, int len)
        {
           A = a; B = b; Len = len;
        }

        static public int operator +(Path a, Path b) => a.Len + b.Len;
    }
}
