namespace StaffLaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staffs employee = new Staffs(
                "Maxim Ivanov Zybenko",
                "12.05.1998",
                "+79991234567",
                "maximivanzy@gmai.com",
                "123456789098",
                20000);

            employee.OutputInfo();
            Console.WriteLine("\n");
            employee.ChangeFSP("Maxim Ivanov Zybenko");
            Console.WriteLine("\n");
            employee.OutputInfo();
            Console.WriteLine("\n");
            employee.ChangeFSP("Maxim Kalinov Zybenko");
            Console.WriteLine("\n");
            employee.OutputInfo();
            Console.WriteLine("\n");
            employee.ChangeTelephone("+79124567890");
            Console.WriteLine("\n");
            employee.OutputInfo();
            Console.WriteLine("\n");
            employee.ChangeSalary(-30000);
            Console.WriteLine("\n");
            employee.OutputInfo();
        }
    }
}
