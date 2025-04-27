using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Cesar
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Cesar(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Сухарики", 1 },
        { "М'ясо", 1 },
        { "Сир", 1 },
        { "Майонез", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
