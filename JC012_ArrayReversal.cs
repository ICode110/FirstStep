using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC012_ArrayReversal
    {
        public static void Reversal()
        {
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine("原数组：" + string.Join("," , numbers));
            //int[] result ={};这是空数组，长度为0，添加元素时候数组超限报错；
            //第一种方法，固定数组长度
            int[] resultInt = new int[numbers.Length];
            int newIntIndex = 0;
            for (int iInt = numbers.Length; iInt > 0; iInt--)
            {
                resultInt[newIntIndex++] = numbers[iInt-1];

            }
            Console.WriteLine("反转后：" + string.Join(",", resultInt));
            //第二种方法，动态数组长度
            List<int> resultList = new List<int>();
            for (int iList = numbers.Length; iList > 0; iList--)
            {
                resultList.Add(numbers[iList - 1]);
            }
            Console.WriteLine("反转后：" + string.Join(",", resultList));
            //第三种方法，原地反转
            for (int iArray = 0; iArray < numbers.Length / 2; iArray++)
            { 
                int temp=numbers[iArray];
                numbers[iArray]=numbers[numbers.Length-1-iArray];
                numbers[numbers.Length - 1 - iArray] = temp;
            }
            Console.WriteLine("反转后："+string.Join(",", numbers));

        }
    }
}
