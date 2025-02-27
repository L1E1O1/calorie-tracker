using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calorie_tracker.main
{
    public class UserProfile
    {
        //all info om användaren
        public string Name { get; set; } 
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int DailyCalorieGoal { get; set; } // hur mycket du ska ta in per dag
        public List<Meal> MealHistory { get; set; } // visa din statistic från förra dgr

        public UserProfile(string name, int age, double weight, double height, int dailyCalorieGoal)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            DailyCalorieGoal = dailyCalorieGoal;
            MealHistory = new List<Meal>();
        }

        //lägg till en ny meal, tar info från klassen Meal
        public void LogMeal(Meal meal)
        {
            MealHistory.Add(meal);
        }

        //exakt som det låter som 
        public int GetTotalCaloriesToday()
        {
            return MealHistory.Where(m => m.Date.Date == DateTime.Today).Sum(m => m.Calories);
        }
    }

}