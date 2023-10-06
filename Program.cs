using System;
using System.Collections.Generic;

namespace Gym_Budy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Welcome message and user input of name, age, weight, and height
            Console.WriteLine("Welcome to Gym Buddy!\nWhat is your name?");
            string name = Console.ReadLine();

            int age, weight, height;

            Console.WriteLine("Please enter your age:");
            bool isValidAge = int.TryParse(Console.ReadLine(), out age);

            // Validate age
            if (!isValidAge || age <= 0)
            {
                Console.WriteLine("Invalid age input. Please enter a valid age.");
                return;
            }

            Console.WriteLine("Please enter your weight (in kilograms):");
            bool isValidWeight = int.TryParse(Console.ReadLine(), out weight);

            // Validate weight
            if (!isValidWeight || weight <= 0)
            {
                Console.WriteLine("Invalid weight input. Please enter a valid weight.");
                return;
            }

            Console.WriteLine("Please enter your height (in centimeters):");
            bool isValidHeight = int.TryParse(Console.ReadLine(), out height);

            // Validate height
            if (!isValidHeight || height <= 0)
            {
                Console.WriteLine("Invalid height input. Please enter a valid height.");
                return;
            }

            int feet, inches;
            string[] heightParts = height.ToString().Split('\'');
            if (heightParts.Length == 2 && int.TryParse(heightParts[0], out feet) && int.TryParse(heightParts[1], out inches))
            {
                Console.WriteLine("Feet: " + feet);
                Console.WriteLine("Inches: " + inches);
            }
            else
            {
                Console.WriteLine("Invalid height format.");
            }

            Console.WriteLine("Please enter your goal:");
            Console.WriteLine("1. Lose weight");
            Console.WriteLine("2. Gain weight");
            Console.WriteLine("3. Maintain weight");

            int goal;
            bool isValidGoal = int.TryParse(Console.ReadLine(), out goal);
            if (!isValidGoal)
            {
                Console.WriteLine("Invalid goal input. Please enter a valid number.");
                return;
            }

            // Additional info
            Console.WriteLine("Please enter your goal (choose a number from the list):");

            Console.WriteLine("1. To Lose weight\n" +
                              "2. To be healthier\n" +
                              "3. To build muscle\n" +
                              "4. To be more flexible\n" +
                              "5. To be more toned\n" +
                              "6. To be more athletic\n" +
                              "7. To be more active\n" +
                              "8. To be more energetic\n" +
                              "9. To be stronger\n" +
                              "10. To be more confident\n" +
                              "11. To be more relaxed\n" +
                              "12. To be more focused\n" +
                              "13. To be more productive\n" +
                              "14. To be more confident\n" +
                              "15. To be more social\n" +
                              "16. To be more attractive\n" +
                              "17. To be more motivated\n" +
                              "18. To be more disciplined\n" +
                              "19. To be more adventurous");

            Console.WriteLine();
            Console.WriteLine("Please enter your training level (choose a number from the list):");
            Console.WriteLine("1. Beginner\n" +
                              "2. Intermediate\n" +
                              "3. Advanced\n" +
                              "4. Professional");
           
            //list of exercises for each goal and training level
            List<Exercise> exercises = new List<Exercise>
            {
                new Exercise("Dumbbell Bench Press", "Chest", "4 sets of 8, 8, 6, 6 reps"),
                new Exercise("Incline Bench Press", "Chest", "4 sets of 8, 8, 6, 6 reps"),
                new Exercise("Cable Crossovers", "Chest", "4 sets of 8 reps"),
                new Exercise("Close Grip Bench Press", "Triceps", "3 sets of 8 reps"),
                // Add more exercises for different categories, goals, and training levels here
            };

            Console.WriteLine("Welcome to Gym Buddy - Exercise Menu");
            Console.WriteLine("Choose an exercise category:");

            // Create a dictionary to categorize exercises
            Dictionary<int, string> categories = new Dictionary<int, string>
            {
                { 1, "Chest" },
                { 2, "Triceps" },
                //more categories needed
            };

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Key}. {category.Value}");
            }

            if (int.TryParse(Console.ReadLine(), out int selectedCategory) && categories.ContainsKey(selectedCategory))
            {
                string selectedCategoryName = categories[selectedCategory];
                Console.WriteLine($"Exercises for {selectedCategoryName}:");

                // Display exercises in the selected category
                foreach (var exercise in exercises)
                {
                    if (exercise.Category == selectedCategoryName)
                    {
                        Console.WriteLine($"Exercise: {exercise.Name}");
                        Console.WriteLine($"Description: {exercise.Description}");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid category selection. Please choose a valid category.");
            }

            //more functionality as needed
        }
    }

    public class Exercise
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Exercise(string name, string category, string description)
        {
            Name = name;
            Category = category;
            Description = description;
        }
    }
}
