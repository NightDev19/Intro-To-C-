using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.Basics
{
    internal class Strings
    {
        private static void PrintSection(string title, Action demoAction)
        {
            Console.WriteLine($"\n{title}");
            Console.WriteLine("   " + new string('-', 35));
            demoAction();
        }

        static void StringLength()
        {
            string sample = "Yamato Nadeshiko Shichi Henge";
            int length = sample.Length;
            Console.WriteLine($"The string length of '{sample}' is {length}");
        }
        static void StringIteration()
        {
            string sample = "Anime";
            Console.Write("Characters: ");
            foreach (char ch in sample)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();
        }
        static void StringComparison()
        {
            string str1 = "Hello",
                   str2 = "World";
            bool comparison = String.Compare(str1, str2) == 0;

            Console.WriteLine(comparison
                ? $"'{str1}' and '{str2}' are equal"
                : $"'{str1}' and '{str2}' are not equal");
        }
        static void CheckSubString()
        {
            string sentence = "Welcome to C# Tutorial";
            string needToFindSubString = "C#";
            bool hasSubString = sentence.Contains(needToFindSubString);

            Console.WriteLine(hasSubString
                ? $"The sentence '{sentence}' contains the substring '{needToFindSubString}'"
                : $"The sentence '{sentence}' does not contain the substring '{needToFindSubString}'");
        }
        static void GetSubString()
        {
            string sampleSentence = "I love python but im using C#";
            string substr = sampleSentence.Substring(7, 6);
            Console.WriteLine($"Original: '{sampleSentence}'");
            Console.WriteLine($"Extracted substring (index 7, length 6): '{substr}'");
        }
        public static void Demonstrate()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       STRING OPERATIONS DEMO");
            Console.WriteLine("========================================");

            var demos = new (string Title, Action Demo)[]
            {
                ("1. STRING LENGTH", StringLength),
                ("2. STRING ITERATION", StringIteration),
                ("3. STRING COMPARISON", StringComparison),
                ("4. CHECK SUBSTRING", CheckSubString),
                ("5. GET SUBSTRING", GetSubString)
            };

            foreach (var demo in demos)
            {
                PrintSection(demo.Title, demo.Demo);
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("           DEMO COMPLETE");
            Console.WriteLine("========================================");
        }
    }
}