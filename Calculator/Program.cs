using System;
using System.Globalization;

namespace Calculator
{
    internal class Program
    {
        static void Sum(double FirstVariables, double SecondVariables)
        {
            Console.WriteLine(FirstVariables + SecondVariables);
        }
        static void Subtraction(double FirstVariables, double SecondVariables)
        {
            Console.WriteLine(FirstVariables - SecondVariables);
        }
        static void Multiplication(double FirstVariables, double SecondVariables)
        {
            Console.WriteLine(FirstVariables * SecondVariables);
        }
        static void Divide(double FirstVariables, double SecondVariables)
        {
            Console.WriteLine(FirstVariables / SecondVariables);
        }

        static void Main()
        {
            double FirstVariables;
            double SecondVariables;
            try
            {
                FirstVariables = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Первый аргумент не число!");
                return;
            }
            string Sing = Console.ReadLine();
            if (!(Sing == "+" ^ Sing == "-" ^ Sing == "*" ^ Sing == "/"))
            {
                Console.WriteLine("Неверный знак");
            }
            else
            {
                try
                {
                    SecondVariables = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Второй агрумент не число!");
                    return;
                }
                if (Sing == "+")
                {
                    Sum(FirstVariables, SecondVariables);
                }
                if (Sing == "-")
                {
                    Subtraction(FirstVariables, SecondVariables);
                }
                if (Sing == "*")
                {
                    Multiplication(FirstVariables, SecondVariables);
                }
                if (Sing == "/")
                {
                    if (SecondVariables == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        Divide(FirstVariables, SecondVariables);
                    }
                }
            }
        }
    }
}
