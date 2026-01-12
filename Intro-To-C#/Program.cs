using System;
using Intro_To_CSharp.Basics;

namespace Intro_To_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("======[Basics - Variables and Data Types]=====\n");
                        Var_And_DataTypes.DemonstrateVariables();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("======[Basics - Control Flow]=====\n");
                        Control_Flow.Demonstrate();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("======[Basics - Error Handing]=====\n");
                        Error_Handling.Demonstrate();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("======[Basics - Loops]=====\n");
                       
                        Console.WriteLine("Coming soon...");
                        break;

                    case "0":
                        exitProgram = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }

                if (!exitProgram)
                {
                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║     C# Learning Topics Menu            ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║  [Basics]                              ║");
            Console.WriteLine("║  1. Variables and Data Types           ║");
            Console.WriteLine("║  2. Control Flow (if/else/switch)      ║");
            Console.WriteLine("║  3. Error Handling(try...catch)        ║");
            Console.WriteLine("║  4. Loops (for/while/foreach)          ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║  0. Exit                               ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nEnter your choice: ");
        }
    }
}