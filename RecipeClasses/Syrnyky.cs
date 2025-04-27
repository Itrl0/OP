using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    public class SirnykyRecipe
    {
        private readonly RecipeProcessor _recipeProcessor;

        public SirnykyRecipe(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
            {
                { "Домашній сир", 1 }, // 1 пачка
                { "Яйце", 1 },       // 1 шт.
                { "Цукор", 1 },      // Кількість не вказана, приймаємо за 1
                { "Борошно", 1 },    // Кількість не вказана, приймаємо за 1
                { "Олія", 1 }        // Кількість не вказана, приймаємо за 1
            };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
