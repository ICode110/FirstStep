using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC018_VerifyEmailFormat
    {
        public string VerifyEmailFormat()
        {
            Console.WriteLine("请输入邮箱");
            string inputEmail=Console.ReadLine();
            if (inputEmail.IndexOf("@") != -1 && inputEmail.IndexOf(".") != -1)
            { 
                int intEmail= inputEmail.IndexOf("@");
                int intDot = inputEmail.IndexOf(".");
                if (intDot > intEmail) 
                {
                    return "格式正确";
                }
                else
                {
                    return "格式错误";
                }
            }
           
                return "格式错误";
           
                
        
        }
    }
}
