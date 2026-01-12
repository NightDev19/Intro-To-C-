using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro_To_CSharp.Basics
{
    internal class Loops
    {
        private const string Separator = "========================================";


        private static readonly Dictionary<string, LoopDemonstration> MenuOptions = new()
        {
            { "1", new LoopDemonstration("For Loop", ForLoop) },
            { "2", new LoopDemonstration("While Loop", WhileLoop) },
            { "3", new LoopDemonstration("Do-While Loop", DoWhileLoop) },
            { "4", new LoopDemonstration("Nested Loop (Heart Pattern)", NestedLoop) },
            { "5", new LoopDemonstration("Break", Break) },
            { "6", new LoopDemonstration("Continue", Continue) },
            { "7", new LoopDemonstration("Foreach Loop", ForeachLoop) },
            { "8", new LoopDemonstration("Goto", Goto) }
        };

        private record LoopDemonstration(string Title, Action DemoAction);

        public static void DisplayMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║         Loops Demonstration            ║");
            Console.WriteLine("╠════════════════════════════════════════╣");

            foreach (var (key, demo) in MenuOptions)
            {
                Console.WriteLine($"║  {key}. {demo.Title,-34} ║");
            }

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

            const int size = 15;

            // Top half of heart
            DrawHeartTop(size);

            // Bottom half of heart
            DrawHeartBottom(size);

            Console.ResetColor();
        }

        private static void DrawHeartTop(int size)
        {
            for (int a = size / 2; a <= size; a += 2)
            {
                WriteSpaces((size - a) / 2);
                WriteCharacters('*', a);
                WriteSpaces(size - a);
                WriteCharacters('*', a - 1);
                Console.WriteLine();
            }
        }

        private static void DrawHeartBottom(int size)
        {
            for (int a = size; a >= 0; a--)
            {
                WriteSpaces(size - a);
                WriteCharacters('*', Math.Max(0, (a * 2) - 1));
                Console.WriteLine();
            }
        }

        private static void WriteSpaces(int count)
        {
            WriteCharacters(' ', count);
        }

        private static void WriteCharacters(char character, int count)
        {
            if (count > 0)
            {
                Console.Write(new string(character, count));
            }
        }

        public static void Break()
        {
            Console.WriteLine("Break Statement - Exiting a loop early:\n");
            Console.WriteLine("Counting from 1 to 10, but will stop at 5:\n");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Reached 5, exiting the loop.");
                    break;
                }
                Console.WriteLine($"Current number: {i}");
            }

            Console.WriteLine("\nLoop exited early using break statement.");
        }

        public static void Continue()
        {
            Console.WriteLine("Continue Statement - Skipping an iteration:\n");
            Console.WriteLine("Counting from 1 to 10, but will skip 5:\n");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Skipping 5.");
                    continue;
                }
                Console.WriteLine($"Current number: {i}");
            }

            Console.WriteLine("\nCompleted loop with continue statement.");
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

        public static void Goto()
        {
            bool errorOccured = true;
            Console.WriteLine("Starting Process...");

            if (errorOccured)
                goto cleanUp;

            Console.WriteLine("This Line will be skipped if an error occurs.");

        cleanUp:
            Console.WriteLine("Performing cleanup operations...");
        }

        public static void Demonstrate()
        {
            string choice;

            do
            {
                DisplayMenu();
                choice = Console.ReadLine()?.Trim() ?? string.Empty;
                Console.Clear();

                if (choice == "0")
                {
                    Console.WriteLine("Returning to main menu...");
                    break;
                }

                if (MenuOptions.TryGetValue(choice, out var demo))
                {
                    ExecuteDemonstration(demo);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                PauseAndClear(choice);

            } while (true);
        }

        private static void ExecuteDemonstration(LoopDemonstration demo)
        {
            ShowHeader(demo.Title);
            demo.DemoAction();
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