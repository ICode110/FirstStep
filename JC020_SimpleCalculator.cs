using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    // 1. 定义自定义异常类
    public class InvalidOperatorException : Exception
    {
        public InvalidOperatorException(string message) : base(message)
        {
        }
    }
    internal class JC020_SimpleCalculator
    {
        public void Calculator()
        {

            Console.WriteLine("控制台计算器已启动。输入 'quit' 退出程序。");

            while (true)
            {
                try
                {
                    // 获取第一个数字
                    Console.WriteLine("请输入第一个数字：");
                    string inputA = Console.ReadLine();
                    if (inputA.ToLower() == "quit") break;
                    double numberA = Convert.ToDouble(inputA);

                    // 获取第二个数字
                    Console.WriteLine("请输入第二个数字：");
                    string inputB = Console.ReadLine();
                    if (inputB.ToLower() == "quit") break;
                    double numberB = Convert.ToDouble(inputB);

                    // 获取运算符
                    Console.WriteLine("请输入运算符 (+, -, *, /)：");
                    string operatorSymbol = Console.ReadLine();
                    if (operatorSymbol.ToLower() == "quit") break;

                    double result;
                    // 根据运算符执行计算，并在default分支抛出自定义异常
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = numberA + numberB;
                            break;
                        case "-":
                            result = numberA - numberB;
                            break;
                        case "*":
                            result = numberA * numberB;
                            break;
                        case "/":
                            if (numberB == 0)
                            {
                                throw new DivideByZeroException("错误：除数不能为零。");
                            }
                            result = numberA / numberB;
                            break;
                        default:
                            // 输入非 + - * / 运算符时，抛出自定义异常
                            throw new InvalidOperatorException($"错误：'{operatorSymbol}' 不是有效的运算符。请使用 +, -, *, / 之一。");
                    }

                    // 输出计算结果
                    Console.WriteLine($"计算结果：{numberA} {operatorSymbol} {numberB} = {result}");
                    Console.WriteLine("------------------------------"); // 分隔线，便于阅读

                }
                catch (InvalidOperatorException ex)
                {
                    // 捕获并提示自定义的非法运算符异常
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("------------------------------");
                }
                catch (DivideByZeroException ex)
                {
                    // 捕获并提示除零错误
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("------------------------------");
                }
                catch (FormatException)
                {
                    // 捕获输入非数字格式的错误
                    Console.WriteLine("错误：请输入有效的数字。");
                    Console.WriteLine("------------------------------");
                }
                catch (Exception ex)
                {
                    // 捕获其他未预见的异常
                    Console.WriteLine($"发生未预期的错误：{ex.Message}");
                    Console.WriteLine("------------------------------");
                }
            }
            Console.WriteLine("计算器程序已退出。");
        }
    }
}