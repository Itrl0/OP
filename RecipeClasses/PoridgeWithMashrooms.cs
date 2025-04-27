using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class PoridgeWithMashrooms
    {
        private readonly RecipeProcessor _recipeProcessor;

        public PoridgeWithMashrooms(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Гречка", 1 },
        { "Шампіньйони", 5 },
        { "Цибуля", 1 },
        { "Олія", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
