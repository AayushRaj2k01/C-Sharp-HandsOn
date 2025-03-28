using System;

class BasicCalculator
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (op)
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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine("Result: " + result);
            }

            Console.WriteLine("Do you want to perform another calculation? (yes/no):");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
            {
                continueCalculating = false;
            }
        }

        Console.WriteLine("Calculator closed.");
    }
}
