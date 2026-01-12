using System;

namespace Intro_To_CSharp.Basics.OOP
{
    internal class Methods
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return (double)x / y;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║        Calculator Menu                 ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║  1. Add                                ║");
            Console.WriteLine("║  2. Subtract                           ║");
            Console.WriteLine("║  3. Multiply                           ║");
            Console.WriteLine("║  4. Divide                             ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║  0. Exit                               ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nEnter your choice: ");
        }


        public void RunCalculator()
        {
            while (true)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Exiting calculator...");
                    break;
                }

                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                double result;

                switch (choice)
                {
                    case 1:
                        result = Add(a, b);
                        break;
                    case 2:
                        result = Subtract(a, b);
                        break;
                    case 3:
                        result = Multiply(a, b);
                        break;
                    case 4:
                        result = Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.WriteLine($"\nResult: {result}\n");
            }
        }
    }
}
