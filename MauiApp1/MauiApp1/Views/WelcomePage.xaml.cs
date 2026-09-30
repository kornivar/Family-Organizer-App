using MauiApp1.Views;

namespace MauiApp1
{
    public partial class WelcomePage : ContentPage
    {
        int count = 0;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnGetStartedClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AuthPage));
        }
    }
}
