using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    /*
     4.	创建一个 BankAccount 类
    具体步骤：
    1.	定义类 BankAccount，包含属性 AccountNumber 和 Balance
    2.	添加 Deposit() 和 Withdraw() 方法
    */
    internal class JC024_OOP_BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Amount { get; set; }

        public void Deposit()
        {
            Balance += Amount;
        }

        public void Withdraw()
        {
            if (Balance >= Amount)
            {
                Balance -= Amount;
                Console.WriteLine("取款成功");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }

        }
    }
}
