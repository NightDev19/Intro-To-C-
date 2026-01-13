using System;

namespace Intro_To_CSharp.Basics
{
    internal class Nullables
    {
        public void ShowNullableExamples()
        {
            // Nullable integer
            int? num1 = null;
            int? num2 = 42;

            // Nullable double
            double? num3 = new double?();
            double? num4 = 3.14159;

            // Nullable boolean
            bool? boolVal = new bool?();

            // Display values
            Console.WriteLine("num1: " + (num1.HasValue ? num1.ToString() : "null"));
            Console.WriteLine("num2: " + (num2.HasValue ? num2.ToString() : "null"));
            Console.WriteLine("num3: " + (num3.HasValue ? num3.ToString() : "null"));
            Console.WriteLine("num4: " + (num4.HasValue ? num4.ToString() : "null"));
            Console.WriteLine("boolVal: " + (boolVal.HasValue ? boolVal.ToString() : "null"));
        }

        public static void Demonstration()
        {
            Nullables demo = new Nullables();
            demo.ShowNullableExamples();
        }
    }
}
