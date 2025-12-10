using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("Enter day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            ClassDate date1 = new ClassDate(day, month, year);
            Console.WriteLine("Текущая: " + date1.Print() + "\n");
            Console.WriteLine("Следующий: " + date1.Next().Print() + "\n");
            Console.WriteLine("Предыдущий: " + date1.Previous().Print() + "\n");

            date1.PrintForward(5);
            Console.WriteLine("\n");
            date1.PrintBackward(5);
        }
    }
}
