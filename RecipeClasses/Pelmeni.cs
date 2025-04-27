using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Pelmeni
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Pelmeni(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Фарш", 1 },
        { "Борошно", 1 },
        { "Яйце", 1 },
        { "Сіль", 1 },
        { "Вода", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }

    }
}
