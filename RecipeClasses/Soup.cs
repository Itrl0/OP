using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Soup
    {

        private readonly RecipeProcessor _recipeProcessor;

        public Soup(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Картопля", 1 },
        { "Фарш", 2 },
        { "Морква", 1 },
        { "Цибуля", 1 },
        { "Зелень", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
