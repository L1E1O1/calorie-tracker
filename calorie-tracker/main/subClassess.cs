using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calorie_tracker.main
{

    // d här r alla meal typer 
    public class Breakfast : Meal
    {
        public Breakfast(string name, int calories, double protein, double carbs, double fats)
            : base(name, calories, protein, carbs, fats) { }

        public override string GetMealType() => "Breakfast";
    }

    public class Lunch : Meal
    {
        public Lunch(string name, int calories, double protein, double carbs, double fats)
            : base(name, calories, protein, carbs, fats) { }

        public override string GetMealType() => "Lunch";
    }

    public class Dinner : Meal
    {
        public Dinner(string name, int calories, double protein, double carbs, double fats)
            : base(name, calories, protein, carbs, fats) { }

        public override string GetMealType() => "Dinner";
    }

    public class Snack : Meal
    {
        public Snack(string name, int calories, double protein, double carbs, double fats)
            : base(name, calories, protein, carbs, fats) { }

        public override string GetMealType() => "Snack";
    }

}
