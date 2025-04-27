using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class BeatedMeat
    {
        private readonly RecipeProcessor _recipeProcessor;

        public BeatedMeat(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
            
            var ingredients = new Dictionary<string, int>
            {
                { "М'ясо", 4 }, 
                { "Яйце", 1 },     
                { "Сіль", 1 }, 
                { "Борошно", 1 },    
                { "Олія", 1 }     
            };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}

