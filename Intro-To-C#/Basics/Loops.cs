using System;

namespace Intro_To_CSharp.Basics
{
    internal class Loops
    {
        private const string Separator = "========================================";

        public static void DisplayMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║         Loops Demonstration            ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║  1. For Loop                           ║");
            Console.WriteLine("║  2. While Loop                         ║");
            Console.WriteLine("║  3. Do-While Loop                      ║");
            Console.WriteLine("║  4. Nested Loop (Heart Pattern)        ║");
            Console.WriteLine("║  5. Foreach Loop                       ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║  0. Back to Main Menu                  ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nEnter your choice: ");
        }

        public static void ForLoop()
        {
            Console.WriteLine("For Loop - Counting from 1 to 10:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Iteration {i}: D ka mahal ng bebe mo!");
            }

            Console.WriteLine("\nNiloloko ka lng nan !");
        }

        public static void WhileLoop()
        {
            Console.WriteLine("While Loop - Counting from 1 to 10:\n");

            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine($"Iteration {count}: D ka mahal ng bebe mo!");
                count++;
            }

            Console.WriteLine("\nNiloloko ka lng nan !");
        }

        public static void DoWhileLoop()
        {
            Console.WriteLine("Do-While Loop - Counting from 1 to 10:\n");

            int count = 1;
            do
            {
                Console.WriteLine($"Iteration {count}: D ka mahal ng bebe mo!");
                count++;
            }
            while (count <= 10);

            Console.WriteLine("\nNiloloko ka lng nan !");
        }

        public static void NestedLoop()
        {
            Console.WriteLine("Nested Loop - Heart Pattern:\n");
            Console.ForegroundColor = ConsoleColor.Red;

            int size = 15;

            for (int a = size / 2; a <= size; a += 2)
            {
                for (int b = 1; b < size - a; b += 2)
                    Console.Write(" ");

                for (int b = 1; b <= a; b++)
                    Console.Write("*");

                for (int b = 1; b <= size - a; b++)
                    Console.Write(" ");

                for (int b = 1; b <= a - 1; b++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int a = size; a >= 0; a--)
            {
                for (int b = a; b < size; b++)
                    Console.Write(" ");

                for (int b = 1; b <= (a * 2) - 1; b++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        public static void ForeachLoop()
        {
            Console.WriteLine("Foreach Loop - Iterating through a collection:\n");

            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("List of fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  - {fruit}");
            }

            Console.WriteLine("\nNumbers demonstration:");
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
                Console.WriteLine($"  Current number: {number}, Running sum: {sum}");
            }

            Console.WriteLine($"\nTotal sum: {sum}");
        }

        public static void Demonstrate()
        {
            string choice;

            do
            {
                DisplayMenu();
                choice = Console.ReadLine()?.Trim() ?? string.Empty;

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        ShowHeader("For Loop");
                        ForLoop();
                        break;

                    case "2":
                        ShowHeader("While Loop");
                        WhileLoop();
                        break;

                    case "3":
                        ShowHeader("Do-While Loop");
                        DoWhileLoop();
                        break;

                    case "4":
                        ShowHeader("Nested Loop");
                        NestedLoop();
                        break;

                    case "5":
                        ShowHeader("Foreach Loop");
                        ForeachLoop();
                        break;

                    case "0":
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                PauseAndClear(choice);

            } while (choice != "0");
        }

        private static void ShowHeader(string title)
        {
            Console.WriteLine($"{Separator}");
            Console.WriteLine($"[{title}]");
            Console.WriteLine($"{Separator}\n");
        }

        private static void PauseAndClear(string choice)
        {
            if (choice == "0")
                return;

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
