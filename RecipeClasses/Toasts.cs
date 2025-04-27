using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Toasts
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Toasts(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Хліб", 1 },
        { "Авокадо", 1 },
        { "Яйце", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
