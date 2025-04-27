using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class FriedPotatos
    {
        private readonly RecipeProcessor _recipeProcessor;

        public FriedPotatos(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Картопля", 3 },
        { "Олія", 1 },
        { "Сіль", 1 },
        { "Соус", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
