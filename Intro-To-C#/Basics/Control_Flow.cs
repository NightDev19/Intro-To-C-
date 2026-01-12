using System;

namespace Intro_To_CSharp.Basics
{
    internal class Control_Flow
    {
        private static void DisplayMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║       Control Flow Demonstration       ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║  1. if                                 ║");
            Console.WriteLine("║  2. if else                            ║");
            Console.WriteLine("║  3. if else if else                    ║");
            Console.WriteLine("║  4. nested if                          ║");
            Console.WriteLine("║  5. switch                             ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║  0. Back to Main Menu                  ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nEnter your choice: ");
        }

        private static void IfExample()
        {
            int number = 5;
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
        }

        private static void IfElseExample()
        {
            int number = -3;
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
            }
        }

        private static void IfElseIfElseExample()
        {
            int number = 0;
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is zero.");
            }
        }

        private static void NestedIfExample()
        {
            int number = 10;
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is positive and even.");
                }
                else
                {
                    Console.WriteLine($"{number} is positive and odd.");
                }
            }
        }

        private static void SwitchExample()
        {
            string day = "Wednesday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the week.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Midweek.");
                    break;
                case "Friday":
                    Console.WriteLine("End of the week.");
                    break;
                default:
                    Console.WriteLine("Another day.");
                    break;
            }
        }

        public static void Demonstrate()
        {
            string choice;
            do
            {
                DisplayMenu();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                switch (choice)
                {
                    case "1":
                        IfExample();
                        break;
                    case "2":
                        IfElseExample();
                        break;
                    case "3":
                        IfElseIfElseExample();
                        break;
                    case "4":
                        NestedIfExample();
                        break;
                    case "5":
                        SwitchExample();
                        break;
                    case "0":
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 0-5.");
                        break;
                }

                if (choice != "0")
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (choice != "0");
        }
    }
}
