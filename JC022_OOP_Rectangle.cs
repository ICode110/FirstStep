using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
     2.	创建一个 Rectangle 类
    具体步骤：
    1.	定义类 Rectangle，包含属性 Length 和 Width
    2.	添加 CalculateArea() 方法计算面积
    */

    internal class JC022_OOP_Rectangle
    {
        public double Length {  get; set; } 
        public double Width { get; set; }

        public double CalculaterArea()
        {
            return Length * Width*1.0;
        }
    }
}
