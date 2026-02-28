using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    
    /*
    2. ‌构造函数与对象初始化‌
‌    题目‌：创建一个 Student 类，包含姓名、年龄和学号，
    使用构造函数完成初始化，并提供一个 ShowInfo() 方法输出信息。
    */
    class JC028_OOPE_Student
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public JC028_OOPE_Student(string name,int age,string id) 
        {
            Name = name;
            Age = age;  
            Id = id;    
        }

        public void ShowInfo()
        {
            Console.WriteLine($"姓名：{Name},年龄：{Age},学号：{Id}");
        }
    }
}
