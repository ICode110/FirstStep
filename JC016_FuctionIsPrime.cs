using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC016_FuctionIsPrime
    {

        public void CallIsPrime()
        {
            while (true)
            {
                Console.WriteLine("请输入一个整数");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsPrime(inputNumber));
            }

        }
        
        public bool IsPrime(int inputNumber)
        {
            if (inputNumber < 2)
            {
                return false;
            }
            else if (inputNumber == 2)
            {
                return true;
            }
            else if (inputNumber % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i * i <= inputNumber; i += 2)
                {
                    if (inputNumber % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        
        }
    }
}
