using calorie_tracker.main;

namespace calorie_tracker.views;

public partial class UserProfilePage : ContentPage
{
    public static UserProfile CurrentUser { get; private set; }

    public UserProfilePage()
    {
        InitializeComponent();
    }

    private void OnCreateProfileClicked(object sender, EventArgs e)
    {
        try
        {
            CurrentUser = new UserProfile(
                nameEntry.Text,
                int.Parse(ageEntry.Text),
                double.Parse(weightEntry.Text),
                double.Parse(heightEntry.Text),
                int.Parse(goalEntry.Text)
            );

            // Gå vidare till AddMealPage
            Navigation.PushAsync(new AddMealPage(CurrentUser));
        }
        catch
        {
            DisplayAlert("Error", "Please fill in all fields correctly.", "OK");
        }
    }
}
