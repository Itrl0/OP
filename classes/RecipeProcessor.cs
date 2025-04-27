using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // Припускаю, що ви використовуєте Windows Forms

namespace OP.classes
{
    public class RecipeProcessor
    {
        private readonly JsonStorage<Ingredient> _ingredientStorage;

        public RecipeProcessor(string ingredientsFilePath)
        {
            _ingredientStorage = new JsonStorage<Ingredient>(ingredientsFilePath);
        }

        // Метод, який буде викликатися при натисканні кнопки "приготувати"
        public bool PrepareRecipe(Dictionary<string, int> recipeIngredients)
        {
            var allIngredients = _ingredientStorage.GetAll();
            var missingIngredients = new List<string>();

            // Перевіряємо наявність усіх необхідних інгредієнтів у достатній кількості
            foreach (var ingredient in recipeIngredients)
            {
                var storageIngredient = allIngredients.FirstOrDefault(i =>
                    string.Equals(i.Name, ingredient.Key, StringComparison.OrdinalIgnoreCase));

                if (storageIngredient == null || storageIngredient.Quantity < ingredient.Value)
                {
                    missingIngredients.Add(ingredient.Key);
                }
            }

            // Якщо якісь інгредієнти відсутні або їх недостатньо, повідомляємо про це
            if (missingIngredients.Count > 0)
            {
                MessageBox.Show($"Недостатньо інгредієнтів: {string.Join(", ", missingIngredients)}",
                    "Помилка приготування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Віднімаємо використані інгредієнти
            foreach (var ingredient in recipeIngredients)
            {
                var storageIngredient = allIngredients.FirstOrDefault(i =>
                    string.Equals(i.Name, ingredient.Key, StringComparison.OrdinalIgnoreCase));

                if (storageIngredient != null)
                {
                    storageIngredient.Quantity -= ingredient.Value;
                    _ingredientStorage.Update(storageIngredient);
                }
            }

            // Зберігаємо зміни у файл
            _ingredientStorage.Save();

            MessageBox.Show("Страву успішно приготовлено!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }


}