using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Olivie
    {

        private readonly RecipeProcessor _recipeProcessor;

        public Olivie(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Картопля", 3 },
        { "Морква", 2 },
        { "Яйця", 1 },
        { "Ковбаса", 1 },
        { "Огірки", 2 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
