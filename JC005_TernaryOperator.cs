using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC005_TernaryOperator
    {
        public static void Ternary()
        {
            Console.WriteLine("请输入一个分数");
            string inputNumber = Console.ReadLine();
            int number =Convert.ToInt32(inputNumber);
            Console.WriteLine( number >= 90 ? "优秀": number >= 80 ? "良好": number >= 60 ? "及格":"不及格");
            Console.ReadKey();
        }
    }
}
