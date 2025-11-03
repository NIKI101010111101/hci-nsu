namespace liblaba6
{
    public static class WordProc
    {
        public static int CountWords(string text) => text.Split(' ').Length;
        public static string SearchLongestWords(string text) => text.Split(" ").OrderBy(x => -x.Length).ToArray()[0];
        public static List<string> ReverseText (string text) => text.Split(' ').Reverse().ToList();
    
        private static bool IsPalindrom(string text)
        {
            bool ispalindrom = true;
            {
                for (int i = 0; i < text.Length / 2; i++)
                    if (text[i] != text[text.Length - i - 1])
                    {
                        ispalindrom = false;
                        break;
                    }
            }
            return ispalindrom;
        }
        public static List<string> SerchPolindrom(string text)
        {
            List<string> polindroms = new List<string>();
            foreach (string word in text.Split(' '))
            if (IsPalindrom(word))
                    polindroms.Add(word);
            return polindroms;
        }
    }
}
