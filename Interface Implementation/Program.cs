using System;

namespace Interface_Implementation
{
    public interface Drawable  //Interface
    {
        void Draw();
    }
    public class Rectangle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Drawing..");
        }
    }
    public class Circle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Circle Drawing...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
            d = new Rectangle();
            d.Draw();
            d = new Circle();
            d.Draw();

        }
    }
}
