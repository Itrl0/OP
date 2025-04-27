using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Burger
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Burger(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            // Створюємо словник інгредієнтів для сирників відповідно до рецепту
            var ingredients = new Dictionary<string, int>
    {
        { "Булочка", 2 },
        { "Фарш", 1 },
        { "Сир", 1 },
        { "Огірок", 1 },
        { "Помідор", 1 },
        {"Циблуля", 1}
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }


    }
}
