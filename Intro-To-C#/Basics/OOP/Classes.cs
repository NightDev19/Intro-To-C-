using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.Basics.OOP
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;
    }
    class BoxTester
    {
        public static void Run()
        {
            Box box1 = new Box();
            Box box2 = new Box();

            double volume = 0.0;
            box1.height = 5.0;
            box1.length = 6.0;
            box1.breadth = 7.0;

            box2.height = 10.0;
            box2.length = 12.0;
            box2.breadth = 13.0;

            volume = box1.height * box1.length * box1.breadth;
            Console.WriteLine($"Volume of Box1 : {volume}");

            volume = box2.height * box2.length * box2.breadth;
            Console.WriteLine($"Volume of Box2 : {volume}");
        }
    }
    internal class Classes
    {
        public static void Demonstrate()
        {
            BoxTester.Run();
        
        }
    }
}
