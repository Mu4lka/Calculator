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
                string expressionString = Console.ReadLine();
                string[] stringSplit = expressionString.Split(Sings);
                var firstNumber = double.Parse(stringSplit[0], CultureInfo.InvariantCulture);
                var secondNumber = double.Parse(expressionString.Substring(stringSplit[0].Length+1), CultureInfo.InvariantCulture);
                string sing = expressionString.Substring(stringSplit[0].Length,1);
                Print(Calculate(firstNumber, secondNumber, sing));
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Данная строка имела неверный формат");
                Console.ReadKey();
            }
        }
        //public static void Calculate(double firstNumber, string sing, double secondNumber)
        //{
        //    if (sing == "+")
        //    {
        //        Console.WriteLine(firstNumber + secondNumber);
        //    }
        //    if (sing == "-")
        //    {
        //        Console.WriteLine(firstNumber - secondNumber);
        //    }
        //    if (sing == "*")
        //    {
        //        Console.WriteLine(firstNumber * secondNumber);
        //    }
        //    if (sing == "/")
        //    {
        //        if (secondNumber == 0)
        //        {
        //            Console.WriteLine("На ноль делить нельзя!");
        //        }
        //        else
        //        {
        //            Console.WriteLine(firstNumber / secondNumber);
        //        }
        //    }
        //}

        //public static void Main()
        //{
        //    double firstNumber;
        //    double secondNumber;
        //    try
        //    {
        //        firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Первое число указано неверно!");
        //        return;
        //    }
        //    string sing = Console.ReadLine();
        //    if (sing == "+" || sing == "-" || sing == "*" || sing == "/")
        //    {
        //        try
        //        {
        //            secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Второе число указано неверно!");
        //            return;
        //        }
        //        Calculate(firstNumber, sing, secondNumber);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Несуществующий знак вычисления!");
        //    }
        //}
    }
}