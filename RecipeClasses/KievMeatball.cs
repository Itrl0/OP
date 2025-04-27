using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class KievMeatball
    {
        private readonly RecipeProcessor _recipeProcessor;

        public KievMeatball(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {

            var ingredients = new Dictionary<string, int>
    {
        { "Фарш", 2 },
        { "Паніровка", 1 },
        { "Хліб", 1 },
        { "Олія", 1 },
        { "Сіль", 1 }
    };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}
