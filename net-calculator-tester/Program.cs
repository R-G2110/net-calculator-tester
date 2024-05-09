using System;

namespace net_calculator_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            float num1 = 10;
            float num2 = 5;

            Console.WriteLine($"Addizione: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Sottrazione: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Divisione: {calculator.Divide(num1, num2)}");
            Console.WriteLine($"Moltiplicazione: {calculator.Multiply(num1, num2)}");
        }
    }
}
