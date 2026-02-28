using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC015_FuctionMultiply
    {

        public void CallMultiply()
        {
            
            Console.WriteLine("请输入乘数");
            double multiplier = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入被乘数");
            double multiplicand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{multiplier}*{multiplicand}={Multiply(multiplier, multiplicand)}");

        }
        
        
        public double Multiply(double multiplier, double multiplicand)
        {
           return multiplier * multiplicand;
        }
    }
}
