using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFridge
{
    public class Recipe
    {
        public string Name { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }

        public Recipe(string name, Dictionary<string, int> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
