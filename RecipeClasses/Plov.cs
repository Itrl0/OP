using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Plov
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Plov(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
            {
                { "Рис", 1 }, // 1 пачка
                { "М'ясо", 1 },       // 1 шт.
                { "Морква", 1 },      // Кількість не вказана, приймаємо за 1
                { "Цибуля", 1 },    // Кількість не вказана, приймаємо за 1
                { "Спеції", 1 }        // Кількість не вказана, приймаємо за 1
            };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}

