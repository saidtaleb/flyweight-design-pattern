namespace Flyweight
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TreeFactory
    {
        private static ICollection<TreeType> _treeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color)
        {
            var treeType = _treeTypes
                .FirstOrDefault(e => e.Name == name && e.Color == color);

            if (treeType is null)
            {
                treeType = new TreeType(name, color);
                _treeTypes.Add(treeType);
            }

            return treeType;
        }
    }
}
