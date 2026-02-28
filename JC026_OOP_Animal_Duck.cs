using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC026_OOP_Animal_Duck:JC026_OOP_Animal,IFeedable,ISwimmable
    {
        public bool CanFly {  get; set; }
        public JC026_OOP_Animal_Duck(string name, int age, bool canFly) : base(name, age)
        {
            CanFly = canFly;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Age}岁的{Name}嘎嘎嘎");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name}在陆地上走，在水里游");
        }
        public void Feed()
        { 
            Console.WriteLine($"{Name}吃种子和昆虫");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name}优雅的在水里游");
        }
    }
}
