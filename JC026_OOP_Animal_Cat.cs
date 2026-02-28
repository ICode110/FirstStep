using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC026_OOP_Animal_Cat : JC026_OOP_Animal
    {
        public bool Climb {  get; set; }    

        public JC026_OOP_Animal_Cat(string name, int age, bool climb ) : base(name, age)
        {
            Climb = climb;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Age}岁的{Name}喵喵喵");
        }

        public void Feed()
        { 
            Console.WriteLine($"{Name}吃鱼和猫粮");
        }

        public void ClimbTree()
        { 
            Console.WriteLine($"{Name}在爬树");
        }
    }
}
