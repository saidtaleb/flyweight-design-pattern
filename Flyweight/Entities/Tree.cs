namespace Flyweight
{
    using System;

    public class Tree
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public TreeType Type { get; private set; }

        public Tree(double x, double y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public void Draw(string canvas)
            => Console.WriteLine($"Draw the canvas {canvas} in ({X},{Y})");
    }
}
