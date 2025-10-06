using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoservise
{
    internal class Service
    {
        public string Name;
        public int Coast;
        public Service(string name, int coast)
        {
            //Name = Console.ReadLine();
            //Coast = Convert.ToInt32(Console.ReadLine());
            Name = name;
            Coast = coast;
        }

        public void Change_coast()
        {
            Console.WriteLine("Введите новую стоимость услуги: ");
            Coast = Convert.ToInt32(Console.ReadLine());
        }

        public void Info()
        {
            Console.WriteLine($"Имя: {Name} Стоимость: {Coast}");
        }
    }
}
