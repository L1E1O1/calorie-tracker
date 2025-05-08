using calorie_tracker.main;
using System.Formats.Tar;

namespace calorie_tracker.views;

public partial class AddMealPage : ContentPage
{
    private UserProfile _user;

    public AddMealPage(UserProfile user)
    {
        InitializeComponent();
        _user = user;
    }

    private void OnAddMealClicked(object sender, EventArgs e)
    {
        try
        {
            string type = mealTypePicker.SelectedItem.ToString();
            DateTime dateTime = datePicker.Date + timePicker.Time;

            Meal meal = type switch
            {
                "Breakfast" => new Breakfast(nameEntry.Text, int.Parse(calEntry.Text), double.Parse(proteinEntry.Text), double.Parse(carbsEntry.Text), double.Parse(fatsEntry.Text)),
                "Lunch" => new Lunch(nameEntry.Text, int.Parse(calEntry.Text), double.Parse(proteinEntry.Text), double.Parse(carbsEntry.Text), double.Parse(fatsEntry.Text)),
                "Dinner" => new Dinner(nameEntry.Text, int.Parse(calEntry.Text), double.Parse(proteinEntry.Text), double.Parse(carbsEntry.Text), double.Parse(fatsEntry.Text)),
                "Snack" => new Snack(nameEntry.Text, int.Parse(calEntry.Text), double.Parse(proteinEntry.Text), double.Parse(carbsEntry.Text), double.Parse(fatsEntry.Text)),
                _ => throw new Exception("Invalid meal type")
            };

            meal.Date = dateTime;
            _user.LogMeal(meal);

            DisplayAlert("Success", "Meal added!", "OK");
        }
        catch
        {
            DisplayAlert("Error", "Please enter all fields correctly.", "OK");
        }
    }

    private void OnViewSummaryClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage(_user));
    }
}
