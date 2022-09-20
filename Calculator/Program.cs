using System;
using System.Globalization;

namespace Calculator
{
    internal class Program
    {
        public static void Calculate(double FirstNumber, string Sing, double SecondNumber)
        {
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

        public static void Main()
        {
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
                Calculate(FirstNumber, Sing, SecondNumber);
            }
            else
            {
                Console.WriteLine("Несуществующий знак вычисления!");
            }
        }
    }
}