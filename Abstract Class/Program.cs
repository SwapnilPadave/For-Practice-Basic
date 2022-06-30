using System;

namespace Abstract_Class
{
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new Rectangle();
            s.Draw();
            s = new Circle();
            s.Draw();
        }
    }
}
