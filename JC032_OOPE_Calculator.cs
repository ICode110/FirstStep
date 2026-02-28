using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    /*
     6.静态成员与实例成员的区别‌
     编写一个 Calculator 类，包含静态方法 Add() 和 Multiply()，
    以及实例方法 Subtract() 和 Divide()。比较它们的调用方式和作用域
     */
    public class JC032_OOPE_Calculator
    {
        public static int Add(int a ,int b)
        { 
            return a + b;
        }

        public static int Multiply(int a, int b)
        { 
            return (a * b);
        }

        public int Subtract(int a ,int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
