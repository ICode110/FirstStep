using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
    5.	创建一个 Car 类
    具体步骤：
    1.	定义类 Car，包含属性 Brand、Model、Year
    2.	添加 StartEngine() 方法
    */
    internal class JC025_OOP_Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"{Brand}{Model} is starting");
        }
    }
}
