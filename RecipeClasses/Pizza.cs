using OP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.RecipeClasses
{
    internal class Pizza
    {
        private readonly RecipeProcessor _recipeProcessor;

        public Pizza(string ingredientsFilePath)
        {
            _recipeProcessor = new RecipeProcessor(ingredientsFilePath);
        }

        public bool Cook()
        {
         
            var ingredients = new Dictionary<string, int>
            {
                { "Сир", 1 }, 
                { "Яйце", 1 },       
                { "Соус", 1 },    
                { "Борошно", 1 },   
                { "Сіль", 1 },
                {"Ковбаса", 1 },
                {"Печериці", 4 }
            };

            return _recipeProcessor.PrepareRecipe(ingredients);
        }
    }
}

