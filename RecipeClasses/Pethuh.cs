using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Pethuh
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Pethuh(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Цукор", 1 },
        { "Вода", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
