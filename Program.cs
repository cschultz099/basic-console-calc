using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Simple Calc Type in your equation:");

            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;

                if(input.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }

                try
                {
                    string[] parts = input.Split(' ');

                    if (parts.Length != 3)
                    {
                        Console.WriteLine("Invalid format. Retype your equation:");
                        continue;
                    }

                    double num1 = Convert.ToDouble(parts[0]);
                    string operation = parts[1];
                    double num2 = Convert.ToDouble(parts[2]);

                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid Operation.");
                            continue;
                    }
                    Console.WriteLine($"Result: {input} = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}