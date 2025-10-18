namespace MethodAndOperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Path A = new Path("A", "B", 20);
            Path B = new Path("B", "C", 80);
            Console.WriteLine(Sum.Summ(1, 2, 3, 4));
            Console.WriteLine(A + B);

            User user = new User("Mick", "Shum");
            user.Print();
        }
    }
}
