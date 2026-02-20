using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC004_DetermineNumber
    {
        public static void OddOrEven()
        {
            Console.WriteLine("请输入一个整数");
            string inputNumber=Console.ReadLine();
            int number=Convert.ToInt32(inputNumber);
            Console.WriteLine(number%2==0?"偶数":"奇数");
            Console.ReadKey();

        
        }
    }
}
