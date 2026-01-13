using System;
using System.Collections.Generic;
using Intro_To_CSharp.Basics;
using Intro_To_CSharp.Basics.OOP;

namespace Intro_To_CSharp
{
    internal class Program
    {
        private static readonly Dictionary<string, (string title, Action action)> MenuActions = new()
        {
            ["1"] = ("Variables and Data Types", Var_And_DataTypes.DemonstrateVariables),
            ["2"] = ("Control Flow", Control_Flow.Demonstrate),
            ["3"] = ("Error Handling", Error_Handling.Demonstrate),
            ["4"] = ("Loops", Loops.Demonstrate),
            ["5"] = ("Array", Arrays.DemonstrateArray),
            ["6"] = ("Nullable" , Nullables.Demonstration),
            ["7"] = ("Encapsulation", Encapsulation.DemonstrateEncapsulation),
            ["8"] = ("Methods", Methods.RunCalculator)
        };

        private static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                string? choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (MenuActions.TryGetValue(choice ?? "", out var menuItem))
                {
                    ExecuteDemo(menuItem.title, menuItem.action);
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please try again.\n");
                }

                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void ExecuteDemo(string title, Action demoAction)
        {
            Console.Clear();
            Console.WriteLine($"======[Basics - {title}]=====\n");
            demoAction();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine(
                "╔════════════════════════════════════════╗\n" +
                "║     C# Learning Topics Menu            ║\n" +
                "╠════════════════════════════════════════╣\n" +
                "║  [Basics]                              ║\n" +
                "║  1. Variables and Data Types           ║\n" +
                "║  2. Control Flow (if/else/switch)      ║\n" +
                "║  3. Error Handling(try...catch)        ║\n" +
                "║  4. Loops (for/while/foreach)          ║\n" +
                "║  5. Arrays                             ║\n" +
                "║  6. Nullable                           ║\n" +
                "╚════════════════════════════════════════╝\n" +
                "╔════════════════════════════════════════╗\n" +
                "║               C# OOP                   ║\n" +
                "╠════════════════════════════════════════╣\n" +
                "║  7. Encapsulation                      ║\n" +
                "║  8. Methods                            ║\n" +
                "║                                        ║\n" +
                "║  0. Exit                               ║\n" +
                "╚════════════════════════════════════════╝"
            );
            Console.Write("\nEnter your choice: ");
        }
    }
}