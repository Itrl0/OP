using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{
    public class RecipeManager
    {
        public List<Recipe> Recipes { get; private set; }
        public User CurrentUser { get; set; }
        public RecipeManager()
        {
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            if (CurrentUser is AdminUser)
            {
                Recipes.Add(recipe);
            }
        }

        public List<Recipe> FindAvailableRecipes(Fridge fridge)
        {
            var availableRecipes = new List<Recipe>();

            foreach (var recipe in Recipes)
            {
                bool canPrepare = recipe.Ingredients.All(ingredient =>
                    fridge.Products.Any(p => p.Name == ingredient.Key && p.Quantity >= ingredient.Value)
                );

                if (canPrepare)
                {
                    availableRecipes.Add(recipe);
                }
            }

            return availableRecipes;
        }
    }
}