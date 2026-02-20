using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC019_HandleException
    {
        public void  Exception()
        {
            
            try
            {
                Console.WriteLine("请输入除数");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入被除数");
                int dividend = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine  (divisor / dividend);
            }
            catch(DivideByZeroException ex)
            {
               
                Console.WriteLine( "除数不能为零");
            }

            
        }
    }
}
