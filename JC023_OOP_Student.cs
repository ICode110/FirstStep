using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    /*
    3.	创建一个 Student 类
    具体步骤：
    1.	定义类 Student，包含属性 Name、Age、Grade
    2.	添加 Study() 方法输出学习信息
    */
    internal class JC023_OOP_Student
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public string Grade {  get; set; }
        public void study()
        {
            Console.WriteLine($"{Name} is studying in grade{Grade}");
        }
    }
}
