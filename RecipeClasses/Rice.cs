using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Rice
    {


        private readonly RecipeProcessor _recipeProcessor;

        public Rice(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Огірок", 1 },
        { "Помідор", 1 },
        { "Цибуля", 1 },
        { "Перець", 1 },
        { "Олія", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
