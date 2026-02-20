using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC006_GuessNumberGame
    {
        public static void GuessNumber()
        {
           
            Random random = new Random();
            int randomNumber = random.Next(1,101);

            while (true)
            {
                Console.WriteLine("请输入猜测值：");
                string inputNumber = Console.ReadLine();
                int Number = Convert.ToInt32(inputNumber);
                if (Number > randomNumber)
                {
                    Console.WriteLine("太大了");
                }
                else if (Number < randomNumber)
                {
                    Console.WriteLine("太小了");
                }
                else
                {
                    Console.WriteLine("恭喜答对，系统数字是{0}，你猜的数字是{1}", randomNumber, Number);
                    break;
                }
            }
            
        }
    }
}
