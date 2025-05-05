using System;
using System.Globalization;

namespace Bank
{
    public class BankAccount
    {
        private static int nextAccountNumber = 1000; // Начальный номер счета, увеличивается при создании нового счета
        private int accountNumber; // Уникальный номер счета
        private decimal balance; // Баланс счета
        private string accountType; // Тип банковского счета (например, сберегательный, текущий)

        private INotifyer _notifyer;
        // Конструктор класса, автоматически присваивает уникальный номер счета
        public BankAccount(string accountType, decimal balance, INotifyer notifyer )
        {
            this.accountNumber = nextAccountNumber++;
            this.accountType = accountType;
            this.balance = balance;
            _notifyer = notifyer;
        }

        // Метод для получения номера счета
        public int GetAccountNumber()
        {
            return accountNumber;
        }

        // Метод для получения текущего баланса счета
        public decimal GetBalance()
        {
            return balance;
        }

        // Метод для получения типа счета
        public string GetAccountType()
        {
            return accountType;
        }

        // Метод для пополнения счета
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"На счет {accountNumber} зачислено {amount}. Новый баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Сумма для зачисления должна быть положительной.");
            }
        }

        // Метод для снятия средств со счета
        public bool Withdraw(decimal amount)
        {
            if (amount > balance) 
            {
                _notifyer.SendMessage($"No");
                return false;
            }       
           
                balance -= amount;
                _notifyer.SendMessage($"Со счета {accountNumber} снято {amount}. Новый баланс: {balance}");            
          return true;           
            
        }

        // Метод для вывода информации о счете
        public string PrintInfo()
        {
            return $"Номер счета: {accountNumber}\nТип счета: {accountType}\nБаланс: {balance}\n";
        }
    }
}

