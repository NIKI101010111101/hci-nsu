using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoservise
{
    internal class AutoService
    {
        private string name = "Road in Forest";
        private List<Service> list;
        private string ServiceName;
        private int ServiceCoast;

        public AutoService()
        {
            list = new List<Service>();
        }

        public void AddServiceProg(string name, int coast)
        {
            ServiceName = name;
            ServiceCoast = coast;
            Service service = new Service(ServiceName, ServiceCoast);
            list.Add(service);
        }
        
        public void AddServiceInput()
        {
            Console.WriteLine("Введите название услуги: ");
            ServiceName = Console.ReadLine();
            Console.WriteLine("Введите стоимость услуги: ");
            ServiceCoast = Convert.ToInt32(Console.ReadLine());
            if (list.Find(x => x.Name == ServiceName) == null)
            {
                Service service = new Service(ServiceName, ServiceCoast);
                list.Add(service);
                Console.WriteLine($"Сервис {ServiceName}  добавлен!\n");
            }
            else
            {
                Console.WriteLine($"Сервис {ServiceName} уже существует!\n");
            }
        }

        public void ChangeCoastService()
        {
            Console.WriteLine("Введите название услуги: ");
            ServiceName = Console.ReadLine();
            foreach (Service service in list)
            {
                if (ServiceName == service.Name)
                {
                    service.Change_coast();
                    Console.WriteLine($"Цена {ServiceName} изменена!\n");
                    service.Info();
                    Console.WriteLine("\n");
                    break;
                }
            }
        }

        public void RemoveService()
        {
            Console.WriteLine("Введите название услуги: ");
            ServiceName = Console.ReadLine();
            foreach (Service service in list)
            {
                if (ServiceName == service.Name)
                {
                    list.Remove(service);
                    Console.WriteLine($"Услуга {ServiceName} удалена!\n");
                    break;
                }
            }

        }
        public void Info()
        {
            foreach (Service service in list) 
                service.Info();
            Console.WriteLine("\n");
        }
    }
}
