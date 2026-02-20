using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC007_NineNineTable
    {
        public static void NineNine()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}×{1}={2}\t", j, i, j * i);
                }
                Console.WriteLine();
            }

        }
    }
}
