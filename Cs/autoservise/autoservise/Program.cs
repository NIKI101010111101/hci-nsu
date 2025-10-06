namespace autoservise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoService autoservice = new AutoService();
            autoservice.AddServiceProg("TO", 10000);
            autoservice.AddServiceProg("Замена колёс", 5000);
            autoservice.AddServiceProg("Замена масла", 7000);
            autoservice.Info();
            autoservice.AddServiceInput();
            autoservice.Info();
            autoservice.ChangeCoastService();
            autoservice.RemoveService();
            autoservice.Info();

        }
    }
}
