using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Sandwitches
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Sandwitches(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Хліб", 1 },
        { "Ковбаса", 1 },
        { "Сир", 1 },
        { "Масло", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }


    }
}
