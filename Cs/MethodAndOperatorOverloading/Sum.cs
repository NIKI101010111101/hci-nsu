using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndOperatorOverloading
{
    internal class Sum
    {
        static public int Summ(int a, int b) {  return a + b; }
        static public int Summ(int a, int b, int c) { return a + b + c; }
        static public int Summ(int a, int b, int c, int d) { return a + b + c + d; }
        static public int Summ(int a, int b, int c, int d, int e) { return a + b + c + d + e; }
    }
}
