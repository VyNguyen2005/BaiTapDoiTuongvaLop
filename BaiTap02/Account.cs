using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
                Console.WriteLine("Nap tien khong thanh cong");
        }
        public void debit(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Thanh toan khong thanh cong");    
        }
        public void tranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
                Console.WriteLine("Chuyen tien khong thanh cong");
        }

    }
}
