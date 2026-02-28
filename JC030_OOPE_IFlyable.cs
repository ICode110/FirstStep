using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
    4.定义了一个 IFlyable 的接口，包含一个 Fly() 方法。
    Bird 类和 Drone 类分别实现了这个接口，重写了 Fly() 方法。
    */
    public interface JC030_OOPE_IFlyable
    {
        void Fly();
    }
}
