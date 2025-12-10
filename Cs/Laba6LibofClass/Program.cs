using liblaba6;

namespace Laba6LibofClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordProc.CountWords("sdfgh fghjk fgh cv b ghj"));
            Console.WriteLine(String.Join(' ',WordProc.SearchLongestWords("sdfgh fghjk fgh cv b ghj")));
            Console.WriteLine(String.Join(' ',WordProc.ReverseText("asdf ghjk 456")));
            Console.WriteLine(String.Join(' ',WordProc.SerchPolindrom("adsf 112211 hhgghh")));

        }
    }
}
