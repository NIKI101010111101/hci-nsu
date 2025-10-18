using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace StaffLaba
{
    internal class Staffs
    {
        private string FSP;
        private string Birhday;
        private string Telephone;
        private string Email;
        private string INN;
        private int Salary;

        public string _FSP
        {
            get => FSP;
            set
            {
                bool flag = false;
                foreach (var item in value)
                    if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z') || item == ' ')
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                    FSP = value;
                else
                    Console.WriteLine("Wrong Firstname Surname Patronymic!");

            }
        }


        public string _Birthday
        {
            get => Birhday;
            set
            {
                bool flag = false;
                foreach (var item in value)
                    if ((item >= '0' && item <= '9') || item == '.')
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                        Birhday = value;
                    else
                        Console.WriteLine("Wrong Birthday!");

            }
        }

        public string _Telephone
        {
            get => Telephone;
            set
            {
                bool flag = false;
                foreach (var item in value)
                    if ((item >= '0' && item <= '9') || item == '+')
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                    Telephone = value;
                else
                    Console.WriteLine("Wrong Telephone!");

            }
        }

        public string _Email
            { get => Email;
            set
            {
                foreach (var item in value)
                    if (item == '@')
                    {
                        Email = value;
                        break;
                    }
                if (Email == null)
                    Console.WriteLine("Wrong E-mail!");
            }
                 }

        public string _INN
        {
            get => INN;
            set
            {
                bool flag = false;
                if (value.Length != 12)
                    Console.WriteLine("Wrong INN!");
                foreach (var item in value)
                    if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z'))
                    {
                        Console.WriteLine("Wrong INN!");
                        flag = true;
                    }
                if (!flag)
                    INN = value;
            }
        }

        public int _Salary
        {
            get => Salary;
            set
            {
                if (value > 0)
                    Salary = value;
                else
                    Console.WriteLine("Wrong Salary!");
            }
        }

        public Staffs(string fsp, string birthday, string telephone, string email, string inn, int salary)
        {
            _FSP = fsp;
            _Birthday = birthday;
            _Telephone = telephone;
            _Email = email;
            _INN = inn;
            _Salary = salary;
        }

        public void ChangeSalary(int salary = 0)
        {
            if (salary == 0)
            {
                _Salary = Convert.ToInt32(Console.ReadLine());
                if (salary == _Salary)
                {
                    Console.WriteLine("Salary is exist!");
                    return;
                }
                Console.WriteLine($"Salary changed on {_Salary} ");
            }
            else
            {
                if (salary == _Salary)
                {
                    Console.WriteLine("Salary is exist!");
                    return;
                }
                _Salary = salary;
                Console.WriteLine($"Salary changed on {_Salary} ");
            }
        }

        public void ChangeFSP(string fsp = " ")
        {
            if (fsp == " ")
            {
                _FSP = Console.ReadLine();
                if (fsp == _FSP)
                {
                    Console.WriteLine("Firstname Surname Patronymic is exist!");
                    return;
                }
                Console.WriteLine($"Firstname Surname Patronymic changed on {_FSP} ");
            }
            else
            {
                if (fsp == _FSP)
                {
                    Console.WriteLine("Firstname Surname Patronymic is exist!");
                    return;
                }
                _FSP = fsp;
                Console.WriteLine($"Firstname Surname Patronymic changed on {_FSP} ");
            }
        }

        public void ChangeTelephone(string telephone = " ")
        {
            if (telephone == " ")
            {
                _Telephone = Console.ReadLine();
                if (telephone == _Telephone)
                {
                    Console.WriteLine("Telephone is exist!");
                    return;
                }
                Console.WriteLine($"Telephone changed on {_Telephone} ");
            }
            else
            {
                if (telephone == _Telephone)
                {
                    Console.WriteLine("Telephone is exist!");
                    return;
                }
                    _Telephone = telephone;
                Console.WriteLine($"Telephone changed on {_Telephone} ");
            }
        }

        public void OutputInfo()
        {
            Console.WriteLine(_FSP);
            Console.WriteLine(_Birthday);
            Console.WriteLine(_Telephone);
            Console.WriteLine(_Email);
            Console.WriteLine(_INN);
            Console.WriteLine(_Salary);
        }
    }
}
