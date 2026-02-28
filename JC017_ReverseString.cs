using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC017_ReverseString
    {

        public void  CallReverseString()
        {
            Console.WriteLine("请输入字母");
            string inputString = Console.ReadLine();
            Console.WriteLine(ReverseString(inputString));
        }
        
        public string ReverseString(string inputString)
        {
            char[] stringSplit = inputString.ToCharArray();

            for (int i = 0; i <= stringSplit.Length / 2; i++)
            {
                char  temp = stringSplit[i];
                stringSplit[i] = stringSplit[stringSplit.Length - 1 - i];
                stringSplit[stringSplit.Length-1-i] = temp;
            }

            return new string(stringSplit);
           

        }
    }
}
