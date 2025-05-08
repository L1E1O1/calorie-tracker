using calorie_tracker.main;

namespace calorie_tracker.views;

public partial class MainPage : ContentPage
{
    public MainPage(UserProfile user)
    {
        InitializeComponent();

        int total = user.GetTotalCaloriesToday();
        summaryLabel.Text = $"Today’s total: {total} / {user.DailyCalorieGoal} kcal";

        var todayMeals = user.MealHistory.Where(m => m.Date.Date == DateTime.Today).ToList();
        mealListView.ItemsSource = todayMeals;
    }
}
