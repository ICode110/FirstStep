using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC003_ExchangeTwoVariables
    {
        public static void ExchangeNumber()
        {
            Console.WriteLine("请输入整数a");
            string inputA=Console.ReadLine();
            Console.WriteLine("请输入整数b");
            string inputB=Console.ReadLine();
            int a = Convert.ToInt32(inputA);
            int b = Convert.ToInt32(inputB);
            //a=10,b=20
            a = a + b;
            //a=30
            b = a - b;
            //b=10
            a = a - b;
            Console.WriteLine("交换前的数字a={0}，b={1}；交换后的数字a={2}，b={3}。",inputA,inputB,a,b);
        }
    }
}
