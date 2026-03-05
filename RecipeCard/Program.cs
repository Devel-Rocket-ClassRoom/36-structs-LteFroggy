using RecipeCard;
using System;

Recipe recipe = new Recipe("토마토 파스타", 2, new Ingredient[] {
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽")
});

Console.WriteLine($"=== 원본 레시피 ===");
recipe.PrintRecipe();
Console.WriteLine();

Console.WriteLine($"=== 4인분으로 변환 ===");
recipe.ScaleRecipe(4).PrintRecipe();
Console.WriteLine();
