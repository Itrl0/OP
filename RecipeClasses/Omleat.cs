using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Omleat
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Omleat(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Яйце", 3 },
        { "Помідор", 1 },
        { "Перець", 1 },
        { "Цибуля", 1 },
        { "Зелень", 1 },
        { "Сіль", 1 },
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
