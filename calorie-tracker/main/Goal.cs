using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calorie_tracker.main
{
    public class Goal
    {
        public string GoalType { get; set; } // e.g., "Calories", "Protein", "Carbs"
        public int TargetAmount { get; set; } // basically ett mål på hur mycket man vill haidag
        public int CurrentProgress { get; set; } //hur mycket du har ätit

        public Goal(string goalType, int targetAmount)
        {
            GoalType = goalType;
            TargetAmount = targetAmount;
            CurrentProgress = 0;
        }

        //uppdaterar progressen 
        public void UpdateProgress(int amount)
        {
            CurrentProgress += amount;
        }

        // ska säga till att målet är nåt
        public bool IsGoalMet()
        {
            return CurrentProgress >= TargetAmount;
        }
    }

}
