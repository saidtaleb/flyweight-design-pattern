namespace Flyweight
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Forest
    {
        private ICollection<Tree> _trees = new List<Tree>();
        public IReadOnlyList<Tree> Trees => _trees.ToList().AsReadOnly();

        public void PlantTree(double x, double y, string name, string color)
        {
            Console.WriteLine($"Plant tree in ({x},{y}) with color {color}");
            var treeType = TreeFactory.GetTreeType(name, color);
            var tree = new Tree(x, y, treeType);
            _trees.Add(tree);
        }

        public void Draw(string canvas)
        {
            Console.WriteLine("Draw forest");
            foreach (var tree in _trees)
                tree.Draw(canvas);
        }
    }
}
