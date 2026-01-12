using System;

namespace Intro_To_CSharp.Basics.OOP
{
    class Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get => width;
            private set => width = value > 0 ? value : throw new ArgumentException("Width must be positive");
        }

        public double Height
        {
            get => height;
            private set => height = value > 0 ? value : throw new ArgumentException("Height must be positive");
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void SetDimensions(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"The area of the rectangle is: {CalculateArea()}");
        }
    }

    class Rectangle2
    {
        protected double width;
        protected double height;

        public Rectangle2(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        double getArea()
        {
            return width * height;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"The area of the rectangle is: {getArea()}");
        }
    }

    class Rectange3
    {

    }
    internal class Encapsulation
    {
        public static void DemonstrateEncapsulation()
        {
            Console.WriteLine("Accepting rectangle details...");

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("\nCalculating area...");
            rectangle.DisplayArea();
            
            Rectangle2 rectangle2 = new Rectangle2(15, 15);
            rectangle2.DisplayArea();

        }
    }
}