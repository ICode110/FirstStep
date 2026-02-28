using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{

    /*1. 创建一个 Person 类‌
    定义一个名为 Person 的类，包含以下属性：
    Name（姓名）
    Age（年龄）
    Gender（性别）
    并添加一个方法 PrintDetails()，用于输出该人的详细信息。
    */
    internal class JC021_OOP_Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public char Gender {  get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"姓名：{Name}，年龄：{Age}，性别：{Gender}");
        }

    }
}
