using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class MashedPotatoes
    {
        private readonly RecipeProcessor _recipeProcessor;

        public MashedPotatoes(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Картопля", 1 },
        { "Молоко", 1 },
        { "Масло", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
