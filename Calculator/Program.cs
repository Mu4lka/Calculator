using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

namespace Calculator
{
    internal class Program
    {
        public static void Print(double result)
        {
            Console.WriteLine($"={result}");
        }
        public static double Calculate(double firstNumber, double secondNumber, string sing)
        {
            switch (sing)
            {
                case "+": return firstNumber + secondNumber;
                case "-": return firstNumber - secondNumber;
                case "*": return firstNumber * secondNumber;
                case "/": return Divide(firstNumber, secondNumber);
            }
            return double.NaN;
        }
        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                Console.WriteLine("На ноль делить нельзя!");
            else
                return firstNumber / secondNumber;
            return double.NaN;
        }
        public static void Main()
        {
            try
            {
                char[] Sings = { '+', '-', '*', '/' };
                string expression = Console.ReadLine();
                string[] operands = expression.Split(Sings);
                var firstNumber = double.Parse(operands[0], CultureInfo.InvariantCulture);
                var secondNumber = double.Parse(expression.Substring(operands[0].Length + 1), CultureInfo.InvariantCulture);
                string sing = expression.Substring(operands[0].Length, 1);
                Print(Calculate(firstNumber, secondNumber, sing));
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Данная строка имела неверный формат");
                Console.ReadKey();
            }
        }
    }
}