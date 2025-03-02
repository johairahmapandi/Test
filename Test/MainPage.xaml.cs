namespace Test
{
    public partial class MainPage : ContentPage
    {
  
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Dashboard_Button(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Dashboard");
        }

    }
}
