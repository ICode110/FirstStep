using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
    3. ‌继承与方法重写‌
    ‌题目‌：定义一个基类 Vehicle，包含虚方法 Run()；
    派生类 Car 和 Bike 分别重写该方法，输出不同交通工具的运行方式。
    */
    public class JC029_OOPE_Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("交通工具正在运行");
        }

    }

    public class Car:JC029_OOPE_Vehicle
    {

        public override void Run()
        {
            Console.WriteLine("汽车在公路上行驶");
        }
    
    }

    public class Bike : JC029_OOPE_Vehicle
    {
        public override void Run()
        {
            Console.WriteLine($"自行车在小路上骑行");
        }
    }
}
