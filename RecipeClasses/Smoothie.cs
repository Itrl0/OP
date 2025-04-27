using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Smoothie
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Smoothie(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Вишня", 1 },
        { "Цукор", 1 },
        { "Морозиво", 1 },
        { "Молоко", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
