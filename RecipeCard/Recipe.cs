using System;

namespace RecipeCard {
    internal struct Recipe {
        public string Name;
        public int Servings;
        public Ingredient[] Ingredients;

        public Recipe(string name, int servings, Ingredient[] ingredients) {
            Name = name;
            Servings = servings;
            Ingredients = ingredients;
        }

        public void PrintRecipe() {
            Console.WriteLine($"[{Name}] ({Servings}인분)");
            Console.WriteLine($"재료 : ");
            foreach (var ingre in Ingredients) {
                Console.WriteLine($"- {ingre.Name} : {ingre.Amount}{ingre.Unit}");
            }
        }
        public Recipe ScaleRecipe(int newServings) {
            Ingredient[] newIngredients = new Ingredient[Ingredients.Length];
            
            for (int i = 0; i < Ingredients.Length; i++) {
                newIngredients[i] = new Ingredient($"{Ingredients[i].Name}", Ingredients[i].Amount / Servings * newServings, Ingredients[i].Unit);
            }

            return new Recipe(Name, newServings, newIngredients);
        }
    }
}
