/*using System;
using System.Collections.Generic;

namespace MealPlanSystem
{
    // Define the IMealPlan interface
    public interface IMealPlan
    {
        void DisplayMealPlan();
        bool ValidateMealPlan();
    }

    //  Create Subtypes of IMealPlan
    public class VegetarianMeal : IMealPlan
    {
        public string MealName { get; set; }
        public List<string> Ingredients { get; set; }

        public VegetarianMeal(string mealName, List<string> ingredients)
        {
            MealName = mealName;
            Ingredients = ingredients;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine($"Vegetarian Meal: {MealName}");
            Console.WriteLine("Ingredients: " + string.Join(", ", Ingredients));
        }

        public bool ValidateMealPlan()
        {
            // Vegetarian meals should not contain meat
            return !Ingredients.Contains("Meat");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public string MealName { get; set; }
        public List<string> Ingredients { get; set; }

        public VeganMeal(string mealName, List<string> ingredients)
        {
            MealName = mealName;
            Ingredients = ingredients;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine($"Vegan Meal: {MealName}");
            Console.WriteLine("Ingredients: " + string.Join(", ", Ingredients));
        }

        public bool ValidateMealPlan()
        {
            // Vegan meals should contain only plant-based ingredients
            foreach (var ingredient in Ingredients)
            {
                if (ingredient == "Dairy" || ingredient == "Egg")
                    return false;
            }
            return true;
        }
    }

    public class KetoMeal : IMealPlan
    {
        public string MealName { get; set; }
        public List<string> Ingredients { get; set; }

        public KetoMeal(string mealName, List<string> ingredients)
        {
            MealName = mealName;
            Ingredients = ingredients;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine($"Keto Meal: {MealName}");
            Console.WriteLine("Ingredients: " + string.Join(", ", Ingredients));
        }

        public bool ValidateMealPlan()
        {
            // Keto meals should be low-carb, high-fat, and high-protein
            return !Ingredients.Contains("Sugar");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public string MealName { get; set; }
        public List<string> Ingredients { get; set; }

        public HighProteinMeal(string mealName, List<string> ingredients)
        {
            MealName = mealName;
            Ingredients = ingredients;
        }

        public void DisplayMealPlan()
        {
            Console.WriteLine($"High Protein Meal: {MealName}");
            Console.WriteLine("Ingredients: " + string.Join(", ", Ingredients));
        }

        public bool ValidateMealPlan()
        {
            // High-protein meals should include protein-rich ingredients
            return Ingredients.Contains("Chicken") || Ingredients.Contains("Tofu");
        }
    }

    // Step 3: Create the generic class Meal<T> where T : IMealPlan
    public class Meal<T> where T : IMealPlan
    {
        public T MealDetails { get; set; }

        public Meal(T mealDetails)
        {
            MealDetails = mealDetails;
        }

        // Display meal details
        public void ShowMealDetails()
        {
            MealDetails.DisplayMealPlan();
        }

        // Validate meal plan
        public void ValidateMeal()
        {
            if (MealDetails.ValidateMealPlan())
                Console.WriteLine("Meal plan is valid.");
            else
                Console.WriteLine("Meal plan is invalid.");
        }
    }

    // Step 4: Generic method to generate and validate meal plans
    public static class MealPlanGenerator
    {
        public static void GenerateMealPlan<T>(T meal, double discount) where T : IMealPlan
        {
            Console.WriteLine("\nGenerating Meal Plan:");
            meal.DisplayMealPlan();
            if (meal.ValidateMealPlan())
            {
                Console.WriteLine($"Discount applied: {discount}%");
                Console.WriteLine("Meal plan is successfully generated and validated.");
            }
            else
            {
                Console.WriteLine("Invalid meal plan. Cannot generate.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample meals
            var vegetarianIngredients = new List<string> { "Rice", "Lentils", "Vegetables" };
            var veganIngredients = new List<string> { "Rice", "Tofu", "Vegetables" };
            var ketoIngredients = new List<string> { "Chicken", "Avocado", "Olive Oil" };
            var highProteinIngredients = new List<string> { "Chicken", "Eggs", "Spinach" };

            // Create meal instances
            VegetarianMeal vegetarianMeal = new VegetarianMeal("Vegetarian Delight", vegetarianIngredients);
            VeganMeal veganMeal = new VeganMeal("Vegan Supreme", veganIngredients);
            KetoMeal ketoMeal = new KetoMeal("Keto Kickstart", ketoIngredients);
            HighProteinMeal highProteinMeal = new HighProteinMeal("High Protein Power", highProteinIngredients);

            // Create generic Meal instances
            Meal<VegetarianMeal> vegetarianMealPlan = new Meal<VegetarianMeal>(vegetarianMeal);
            Meal<VeganMeal> veganMealPlan = new Meal<VeganMeal>(veganMeal);
            Meal<KetoMeal> ketoMealPlan = new Meal<KetoMeal>(ketoMeal);
            Meal<HighProteinMeal> highProteinMealPlan = new Meal<HighProteinMeal>(highProteinMeal);

            // Display and validate meal plans
            vegetarianMealPlan.ShowMealDetails();
            vegetarianMealPlan.ValidateMeal();

            veganMealPlan.ShowMealDetails();
            veganMealPlan.ValidateMeal();

            // Generate and validate meal plans using generic method
            MealPlanGenerator.GenerateMealPlan(vegetarianMeal, 10);
            MealPlanGenerator.GenerateMealPlan(veganMeal, 15);
        }
    }
}
*/