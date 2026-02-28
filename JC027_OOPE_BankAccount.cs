using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    /*1. ‌封装与属性控制‌
    ‌题目‌：定义一个 BankAccount 类，包含账户名（Name）和余额（Balance）属性。
    余额只能通过方法修改，且不能为负数。
    */
    class JC027_OOPE_BankAccount
    {
        private string _name;
        private decimal _balance;
        

        public string Name { get { return _name; } set { _name = value; } }
        public decimal Balance 
        { 
            get { return _balance; } 
            private set { _balance = value>=0?value:0; } 
        }


        public void Deposit(decimal amount)
        {
            if (amount > 0) 
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            { 
                Balance -= amount;
            }
        }
    }
}
