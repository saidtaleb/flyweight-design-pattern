namespace Flyweight
{
    public class TreeType
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
