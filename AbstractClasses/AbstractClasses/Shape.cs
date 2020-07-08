using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied shape onto clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
