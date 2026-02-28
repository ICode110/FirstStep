using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    internal class JC026_OOP_Animal_Dog:JC026_OOP_Animal
    {
        public string Breed { get; set; }
        public JC026_OOP_Animal_Dog(string name,int age,string breed):base(name,age) 
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Age}岁的{Name}汪汪汪");
        }

        public override void Move()
        {
            Console.WriteLine($"{Breed}用4条腿快速的跑");
        }

        
    }
}
