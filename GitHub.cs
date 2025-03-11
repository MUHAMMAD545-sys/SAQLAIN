using System;

class AdvancedCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       Advanced Calculator       ");
            Console.WriteLine("=================================");
            try
            {
                Console.WriteLine("\nEnter the first number (or type 'exit' to quit):");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") break;
                double num1 = Convert.ToDouble(input1);

                Console.WriteLine("Enter the second number (or press Enter to perform single-number operations like Square Root):");
                string input2 = Console.ReadLine();
                double num2 = 0;
                bool isSingleInput = string.IsNullOrWhiteSpace(input2);
                if (!isSingleInput)
                    num2 = Convert.ToDouble(input2);

                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.WriteLine("6. Exponentiation (^)");
                Console.WriteLine("7. Square Root (√, only for single number)");
                Console.Write("Your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                double result = 0;

                switch (choice)
                {
                    case 1: result = num1 + num2; break;
                    case 2: result = num1 - num2; break;
                    case 3: result = num1 * num2; break;
                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                    case 5: result = num1 % num2; break;
                    case 6: result = Math.Pow(num1, num2); break;
                    case 7:
                        if (isSingleInput)
                            result = Math.Sqrt(num1);
                        else
                            Console.WriteLine("Error: Square root requires only one input.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        continue;
                }

                if (choice >= 1 && choice <= 6 || (choice == 7 && isSingleInput))
                    Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Invalid input. Please try again.");
            }

            Console.WriteLine("\nPress any key to continue or type 'exit' to quit.");
            if (Console.ReadLine().ToLower() == "exit")
                break;
        }
    }
}
