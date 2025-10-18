using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndOperatorOverloading
{
    internal class User
    {

        private string Login;

        public string _login
        { get => Login;
            set
            { 
                if (value.Length >= 4 && value.Length <= 20)
                    Login = value;
                else
                    Console.WriteLine("Логин не подхидит");
            }
        }

        private string Password;

        public string _password
        {
            get => Password;
            set
            {
                if (value.Length >= 4 && value.Length <= 20)
                    Password = value;
                else
                    Console.WriteLine("Не надёжный пароль");
            }
        }
        public User(string login, string password)
        {
            _login = login;
            _password = password;
            
        }

        public void Print()
        {
            Console.WriteLine(_login +" " + _password);
        }


    }
}
