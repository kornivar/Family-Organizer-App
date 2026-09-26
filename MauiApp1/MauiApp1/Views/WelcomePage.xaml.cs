namespace MauiApp1
{
    public partial class WelcomePage : ContentPage
    {
        int count = 0;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void OnGetStartedClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("Get Started button clicked");
            //await Shell.Current.GoToAsync("LoginPage");
        }
    }
}
