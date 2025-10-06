using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    internal class BankAccount
    {
        private int AccountID;
        private int Balance;
        private int Pin;
        private string Owner;
        private int Money = 0;

        public BankAccount(int accountID, int balance, int pin, string owner)
        {
            AccountID = accountID;
            Balance = balance;
            Pin = pin;
            Owner = owner;
        }

        public BankAccount()
        {
            Console.WriteLine("Введите номер счёта: ");
            AccountID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите баланс: ");
            Balance = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите Пин-код: ");
            Pin = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите ФИО: ");
            Owner = Console.ReadLine();


        }

        private bool WithdrawMoneyCheck(int money, int balance)
        {
            if (money > balance && money != 0)
                return true;
            else
                return false;
        }

        public void WithdrowMoney()
        {
            Console.WriteLine("Введите Пин-код: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите кол-во денег которые хотите снять: ");
            Money = Convert.ToInt32(Console.ReadLine());
            Money = Math.Abs(Money);

            if (WithdrawMoneyCheck(Money, Balance) && pin == Pin)
            {
                Balance -= Money;
                Console.WriteLine($"Со счёта снято: {Money} | Баланс равен: {Balance}\n");
            }
            else if (pin != Pin)
                Console.WriteLine("Неверный Пин-код!\n");
            else
                Console.WriteLine("Недостаточно средств\n");
        }

        public void PutMoney()
        {
            Console.WriteLine("Введите Пин-код: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите кол-во денег которые хотите положить: ");
            Money = Convert.ToInt32(Console.ReadLine());
            Money = Math.Abs(Money);
            if (pin == Pin)
            {
                Balance += Money;
                Console.WriteLine($"На счёт добавленно: {Money} | Баланс равен: {Balance}\n");
            }
            else
                Console.WriteLine("Неверный Пин-код!\n");
        }


        public void Info()
        {
            Console.WriteLine($"Номер счёта: {AccountID}");
            Console.WriteLine($"Владелец: {Owner}");
            Console.WriteLine($"Пин-код: {Pin}");
            Console.WriteLine($"Баланс: {Balance}\n");
        }
    }

}
