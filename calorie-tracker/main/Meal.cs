using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calorie_tracker.main
{
    public abstract class Meal
    {
        //info som behövs för att identifera och skapa en ny meal
        public string Name { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public DateTime Date { get; set; }


        //den här skickas till userProfile
        protected Meal(string name, int calories, double protein, double carbs, double fats)
        {
            Name = name;
            Calories = calories;
            Protein = protein;
            Carbs = carbs;
            Fats = fats;
            Date = DateTime.Now;
        }

        public abstract string GetMealType();  // Polymorphism - varje meal ska ovveridas av subtyp
    }

}
