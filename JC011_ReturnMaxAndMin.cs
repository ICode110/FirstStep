using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC011_ReturnMaxAndMin
    {
        public static void MaxAndMin()
        {
            int[] scores = { 85, 92, 78, 96, 88 };
            int maxNum= scores[0];
            int minNum= scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (maxNum < scores[i])
                { 
                    maxNum = scores[i];
                
                }
            
            }
            for (int j = 0; j < scores.Length; j++)
            {
                if (minNum > scores[j])
                { 
                    minNum = scores[j];
                }
            
            }

            Console.WriteLine("数组{{85, 92, 78, 96, 88}}最大值：{0}，最小值：{1}", maxNum,minNum);
        
        }
    }
}
