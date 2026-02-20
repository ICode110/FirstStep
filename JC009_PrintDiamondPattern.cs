using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC009_PrintDiamondPattern
    {
        public static void PrintDiamond()
        {
            try
            {
                Console.WriteLine("请输入一个奇数");
                string inputString = Console.ReadLine();
                int number = Convert.ToInt32(inputString);
                //上半部分
                for (int i = 1; i <= number; i += 2)
                {
                    //先输出前面空格
                    for (int j = 1; j <= (number - i) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    //然后输出*号
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //下半部分
                for (int i = number - 2; i >= 1; i -= 2)
                {
                    //先输出前面空格
                    for (int j = 1; j <= (number - i) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    //然后输出*号
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
