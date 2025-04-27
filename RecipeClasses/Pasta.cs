using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Pasta
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Pasta(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Макарони", 1 }, // 1 пачка
        { "Фарш", 1 },       // 1 шт.
        { "Цибуля", 1 },      // Кількість не вказана, приймаємо за 1
        { "Сіль", 1 },    // Кількість не вказана, приймаємо за 1
        { "Олія", 1 } ,
        {"Шампіньйони", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
