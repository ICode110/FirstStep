using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
     7. 使用封装和访问修饰符‌
     创建一个 Person 类，使用私有字段（private fields）和公共属性（public properties）
     来管理姓名（Name）、年龄（Age）等信息。确保通过属性进行数据验证。
     */
    internal class JC033_OOPE_Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = string.IsNullOrEmpty(value)?"未知" : value; } }
        public int Age { get { return age; } set { age = value<0?0:value; } }

        public void showInfo()
        {
            Console.WriteLine($"姓名{Name},年龄{Age}"); 
        }
    }
}
