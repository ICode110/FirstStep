using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    /*
    6.	高级面向对象编程题
    具体步骤：
    1.	创建抽象基类 Animal，包含抽象方法 MakeSound() 和虚方法 Move()
    2.	创建具体子类 Dog、Cat、Duck 继承 Animal
    3.	定义接口 IFeedable 和 ISwimmable
    4.	使用泛型类 AnimalShelter<T> 和静态类 AnimalHelper
    */
    public abstract class JC026_OOP_Animal
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        

        protected JC026_OOP_Animal(string name,int age) 
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();
        public virtual void Move()
        {
            Console.WriteLine($"{Name}is Moving");
        }
    }


    public interface IFeedable
    {
        void Feed();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class AnimalShelter<T> where T : JC026_OOP_Animal
    { 
        private List<T> animals = new List<T>();
        public void AddAnimal(T animal)
        {
            animals.Add(animal);
        }

        public void DisplayAllAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Move();
                animal.MakeSound();
            }
        }

        public T GetAnimalByName(string name)
        { 
            return  animals.FirstOrDefault(a => a.Name == name);
        }
    }

    public static class AnimalHelper
    {
        public static void PrintAnimalDetails(JC026_OOP_Animal animal)
        { 
            Console.WriteLine($"---Animal Details---");
            animal.Move();
            animal.MakeSound();
            Console.WriteLine();

        }
    
    }
  

}
