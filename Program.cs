using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    public class Program
    {
        static void Main(string[] args)
        {
            //JC001_TemperatureConversion.FToC();
            //JC002_InformationEntry.UserInformation();
            //原理？？
            //JC003_ExchangeTwoVariables.ExchangeNumber();
            //JC004_DetermineNumber.OddOrEven();
            //JC005_TernaryOperator.Ternary();
            //JC006_GuessNumberGame.GuessNumber();
            //JC007_NineNineTable.NineNine();
            //JC008_SumEvenInOneHundred.EvenSum();
            //分类？？
            //JC009_PrintDiamondPattern.PrintDiamond();
            //JC010_LoginSystem.Login();
            //JC011_ReturnMaxAndMin.MaxAndMin();
            //交换？？
            //JC012_ArrayReversal.Reversal();
            //字典？？
            //JC013_CountWord.wordNumber();
            //JC014_CountScoreStudents.CountScore();
            //JC015
            //JC015_FuctionMultiply JC015 = new JC015_FuctionMultiply();
            //JC015.CallMultiply();
            //JC016
            //JC016_FuctionIsPrime JC016 = new JC016_FuctionIsPrime();
            //JC016.CallIsPrime();
            //JC017
            //JC017_ReverseString JC017 = new JC017_ReverseString();
            //JC017.CallReverseString();
            //JC018
            //JC018_VerifyEmailFormat JC018 = new JC018_VerifyEmailFormat();
            //string verifyEmailFormatResult = JC018.VerifyEmailFormat();
            //Console.WriteLine(verifyEmailFormatResult);
            //JC019
            //JC019_HandleException JC019 = new JC019_HandleException();
            //JC019.Exception();
            //JC020
            //JC020_SimpleCalculator JC020 = new JC020_SimpleCalculator();
            //JC020.Calculator();
            //JC021
            //JC021_OOP_Person JC021 = new JC021_OOP_Person();
            //JC021.Name= "张三";   
            //JC021.Age= 10;
            //JC021.Gender = '男';
            //JC021.PrintDetails();
            //JC022
            //JC022_OOP_Rectangle JC022 = new JC022_OOP_Rectangle();
            //JC022.Length = 0.8;
            //JC022.Width = 0.09;
            //double result = JC022.CalculaterArea();
            //Console.WriteLine(result);
            //JC023
            //JC023_OOP_Student  JC023=new JC023_OOP_Student();
            //JC023.Name = "李四";
            //JC023.Grade = "三";
            //JC023.study();
            //JC024
            //JC024_OOP_BankAccount JC024 = new JC024_OOP_BankAccount();
            //JC024.Balance = 10;
            //JC024.Amount = 500;
            //JC024.Deposit();
            //JC024.Withdraw();
            //JC025
            //JC025_OOP_Car JC025=new JC025_OOP_Car();
            //JC025.Brand = "幻影";
            //JC025.Model ="888";
            //JC025.Year = 2026;
            //JC025.StartEngine();
            //JC026
            //多态展示
            JC026_OOP_Animal_Cat JC026Cat = new JC026_OOP_Animal_Cat("小猫", 1, true );
 
            JC026_OOP_Animal_Dog JC026Dog = new JC026_OOP_Animal_Dog("小狗",2,"金毛");
           
            JC026_OOP_Animal_Duck JC026Duck = new JC026_OOP_Animal_Duck("小鸭", 3,true);

            JC026_OOP_Animal[] animals = { JC026Cat, JC026Dog, JC026Duck };
            foreach (JC026_OOP_Animal animal in animals)
            {
                animal.Move();
                animal.MakeSound();
            }
            Console.WriteLine("----------------分割线--------------------");
            //泛型类
            var dogShelter = new AnimalShelter<JC026_OOP_Animal_Dog>();
            dogShelter.AddAnimal(new JC026_OOP_Animal_Dog("大狗", 6, "布迪"));
            dogShelter.AddAnimal(new JC026_OOP_Animal_Dog("小狗", 7, "泰迪"));
            dogShelter.DisplayAllAnimals();
            Console.WriteLine("----------------分割线--------------------");
            //静态类调用
            AnimalHelper.PrintAnimalDetails(dogShelter.GetAnimalByName("小狗"));


        }
    }
}
