// This is an independent project of an individual developer. 
// Dear PVS-Studio, please check it.

using System;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.Write("Первое число: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Второе число: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Операция (+ или -): ");
            string op = Console.ReadLine()!;

            double result = op switch
            {
                "+" => calc.Add(a, b),
                "-" => calc.Subtract(a, b),
                _   => throw new InvalidOperationException("Неизвестная операция")
            };

            Console.WriteLine($"Результат: {result}");
        }
    }
}