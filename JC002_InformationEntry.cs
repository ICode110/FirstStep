using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC002_InformationEntry
    {
        public static void UserInformation()
        {
            Console.WriteLine("请输入用户姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入用户年龄");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);
            Console.WriteLine("请输入用户身高");
            string inputHeight=Console.ReadLine();
            double height=Convert.ToDouble(inputHeight);
            Console.WriteLine("您好，{0}，今年{1}岁，身高{2}米。",name,age,height);
            Console.ReadKey();
        }
    }
}
