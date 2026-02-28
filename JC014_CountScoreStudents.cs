using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC014_CountScoreStudents
    {
        public static void CountScore()
        {
            List<int>  scores = new List<int>();
            int sum = 0;
            int passNumber = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"请输入学生{i}的成绩(0~100)");
                string students = "inputNumber" + i;
                students = Console.ReadLine();
                int number = Convert.ToInt32(students);
                scores.Add(number);
            }
            for (int j = 1; j < scores.Count; j++)
            { 
                
                sum+= scores[j];
                if (scores[j] >= 60)
                { 
                    passNumber++;
                }
                
            }

            Console.WriteLine($"平均分：{sum / scores.Count}，最高分：{scores.Max()},最低分：{scores.Min()},及格人数{passNumber}");
        }
    }
}
