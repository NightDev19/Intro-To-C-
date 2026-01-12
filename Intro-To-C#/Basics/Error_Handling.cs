using System;

namespace Intro_To_CSharp.Basics
{
    internal class Error_Handling
    {
        public static void Demonstrate()
        {
            Console.WriteLine("=== Error Handling in C# ===\n");

            try
            {
                
                int number = int.Parse("NotANumber");

                // Example of throwing a custom exception
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Number cannot be negative.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Out of range error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nError handling demonstration complete.\n");
            }
        }
    }
}
