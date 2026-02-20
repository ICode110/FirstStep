using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC010_LoginSystem
    {
        public static void Login()
        {
            string userName = "admin";
            string password = "123456";
            int i = 1;
            
            while(i<=3)
            {
                Console.WriteLine("请输入用户名！");
                string inputName = Console.ReadLine();
                Console.WriteLine("请输入用户密码！");
                string inputPassword = Console.ReadLine();
                if (inputName == userName && inputPassword == password)
                {
                    Console.WriteLine("登录成功!");
                    Console.ReadKey();
                    break;

                }
                else
                {
                    Console.WriteLine("用户名或密码错误!");
                    i++;

                    if (i >3)
                    {
                        Console.WriteLine("账户已锁定");
                    }

                }
            }
            
          
           

        
        }
    }
}
