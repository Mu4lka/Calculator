using System;
using System.Globalization;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Калькулятор в столбик");
            Console.WriteLine("1. Впишите в первую строку число");
            Console.WriteLine("2. Впишите во вторую строку знак вычисления: +, -, *, /");
            Console.WriteLine("3. Впишите в третью строку число");
            double FirstNumber;
            double SecondNumber;
            try
            {
                FirstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Первое число указано неверно!");
                return;
            }
            string Sing = Console.ReadLine();
            if (Sing == "+" ^ Sing == "-" ^ Sing == "*" ^ Sing == "/")
            {
                try
                {
                    SecondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Второе число указано неверно!");
                    return;
                }
                if (Sing == "+")
                {
                    Console.WriteLine(FirstNumber + SecondNumber);
                }
                if (Sing == "-")
                {
                    Console.WriteLine(FirstNumber - SecondNumber);
                }
                if (Sing == "*")
                {
                    Console.WriteLine(FirstNumber * SecondNumber);
                }
                if (Sing == "/")
                {
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        Console.WriteLine(FirstNumber / SecondNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("Несуществующий знак вычисления!");
            }
        }
    }
}
