using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.Core.IOGroup;
using System.Threading;
using Cosmos.HAL;
using Cosmos.Core;
using Cosmos.Common;
using System.Net;
using Cosmos.System.Network;

namespace PunnoOS.apps
{
    public static class Calculator
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] PunnoOS: Calculator");
        }

        public static void Main(string input)
        {
            var command = input.Substring(11).Trim(); // Remove the "calculator " prefix and trim the input
            string[] parts = command.Split(' '); // Split input by spaces

            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid Input. Usage: num1 operator num2");
                return;
            }

            double num1, num2;
            char operation;

            try
            {
                num1 = double.Parse(parts[0]);
                operation = parts[1][0]; // Assuming single-character operator
                num2 = double.Parse(parts[2]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format. Please use numbers.");
                return;
            }

            double result = Calculate(num1, operation, num2);
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }

        private static double Calculate(double num1, char operation, double num2)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero!");
                        return double.NaN; // Not-a-Number
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Invalid operator. Supported operators: +, -, *, /");
                    return double.NaN;
            }
        }
    }
}