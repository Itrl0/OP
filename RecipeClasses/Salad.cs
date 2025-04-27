using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Salad
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Salad(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Огірок", 1 },
        { "Помідор", 2 },
        { "Перець", 1 },
        { "Цибуля", 1 },
        { "Сіль", 1 },
        { "Олія", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
