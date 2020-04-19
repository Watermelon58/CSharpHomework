using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1 = Convert.ToDouble(Console.ReadLine());
                double num2 = Convert.ToDouble(Console.ReadLine());
                char operater = Convert.ToChar(Console.ReadLine());
                double res=MyCalculate(num1, num2, operater);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("解析错误"+e.Message);
            }

        }

        private static double MyCalculate(double num1, double num2, double operater)
        {
            switch (operater)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    Console.WriteLine("Wrong operater!");
                    return double.NaN;
            }
        }
    }
}
