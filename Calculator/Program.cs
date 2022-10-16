using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

namespace Calculator
{
    internal class Program
    {
        public static void Calculate(double firstNumber, string sing, double secondNumber)
        {
            if (sing == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            if (sing == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            if (sing == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            if (sing == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                }
                else
                {
                    Console.WriteLine(firstNumber / secondNumber);
                }
            }
        }
        public static void Main()
        {
            double firstNumber;
            double secondNumber;
            try
            {
                firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Первое число указано неверно!");
                return;
            }
            string sing = Console.ReadLine();
            if (sing == "+" || sing == "-" || sing == "*" || sing == "/")
            {
                try
                {
                    secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Второе число указано неверно!");
                    return;
                }
                Calculate(firstNumber, sing, secondNumber);
            }
            else
            {
                Console.WriteLine("Несуществующий знак вычисления!");
            }
        }
    }
}