using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FirstStep
{
    internal class JC013_CountWord
    {
        public static void wordNumber()
        {
            string wordString = "apple banana apple orange banana apple";

            string[] wordSplit = wordString.Split(' ');
            
            Dictionary<string,int> wordDic=new Dictionary<string, int>();
            foreach (string word in wordSplit)
            {
                if (wordDic.ContainsKey(word))
                {
                    wordDic[word]++;
                }
                else
                {
                    wordDic[word] = 1;
                }
            }

            foreach(KeyValuePair<string,int> kvp in wordDic)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}次");
            }
           
        }

    }
}
