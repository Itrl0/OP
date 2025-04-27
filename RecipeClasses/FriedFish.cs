using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class FriedFish
    {
        private readonly RecipeProcessor _recipeProcessor;

        public FriedFish(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Риба", 1 },
        { "Сіль", 1 },
        { "Борошно", 1 },
        { "Олія", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
