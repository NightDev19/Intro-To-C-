using System;

namespace Intro_To_CSharp.Basics
{
    internal class Var_And_DataTypes
    {
        public static void DemonstrateVariables()
        {
            Console.WriteLine("=== Variables and Data Types in C# ===\n");

            DisplayIntegerTypes();
            DisplayFloatingPointTypes();
            DisplayCharAndStringTypes();
            DisplayBooleanTypes();
            DisplayImplicitlyTypedVariables();
            DisplayObjectTypes();
            DisplayTypeRanges();
        }

        private static void DisplayIntegerTypes()
        {
            int age = 25;
            long population = 7_800_000_000L;
            short temperature = -15;
            byte percentage = 100;

            Console.WriteLine("--- Integer Types ---");
            Console.WriteLine($"int age = {age}");
            Console.WriteLine($"long population = {population}");
            Console.WriteLine($"short temperature = {temperature}");
            Console.WriteLine($"byte percentage = {percentage}\n");
        }

        private static void DisplayFloatingPointTypes()
        {
            float height = 5.9f;
            double pi = 3.14159265359;
            decimal price = 19.99m;

            Console.WriteLine("--- Floating-Point Types ---");
            Console.WriteLine($"float height = {height}");
            Console.WriteLine($"double pi = {pi}");
            Console.WriteLine($"decimal price = {price:C}\n");
        }

        private static void DisplayCharAndStringTypes()
        {
            char grade = 'A';
            string name = "John Doe";

            Console.WriteLine("--- Character and String Types ---");
            Console.WriteLine($"char grade = '{grade}'");
            Console.WriteLine($"string name = \"{name}\"\n");
        }

        private static void DisplayBooleanTypes()
        {
            bool isStudent = true;
            bool hasGraduated = false;

            Console.WriteLine("--- Boolean Types ---");
            Console.WriteLine($"bool isStudent = {isStudent}");
            Console.WriteLine($"bool hasGraduated = {hasGraduated}\n");
        }

        private static void DisplayImplicitlyTypedVariables()
        {
            var number = 10;
            var message = "Hello, World!";
            var isActive = true;

            Console.WriteLine("--- Implicitly Typed Variables (var) ---");
            Console.WriteLine($"var number = {number} (Type: {number.GetType().Name})");
            Console.WriteLine($"var message = \"{message}\" (Type: {message.GetType().Name})");
            Console.WriteLine($"var isActive = {isActive} (Type: {isActive.GetType().Name})\n");
        }

        private static void DisplayObjectTypes()
        {
            object obj1 = 42;
            object obj2 = "Text";
            object obj3 = true;

            Console.WriteLine("--- Object Types ---");
            Console.WriteLine($"object obj1 = {obj1} (Actual Type: {obj1.GetType().Name})");
            Console.WriteLine($"object obj2 = \"{obj2}\" (Actual Type: {obj2.GetType().Name})");
            Console.WriteLine($"object obj3 = {obj3} (Actual Type: {obj3.GetType().Name})\n");
        }

        private static void DisplayTypeRanges()
        {
            Console.WriteLine("--- Type Ranges ---");
            Console.WriteLine($"int range: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long range: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"short range: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"byte range: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"float range: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double range: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal range: {decimal.MinValue} to {decimal.MaxValue}\n");
        }
    }
}
