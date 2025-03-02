using Test.Models;
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
        private async void OnProductTapped(object sender, EventArgs e)
        {
            var selectedProduct = new ProductModel
            {
                Name = "Sample Dress",
                Description = "A beautiful strapless dress.",
                Price = 1000
            };

            // Navigate to OrderDetails and pass the object
            await Shell.Current.GoToAsync(nameof(OrderDetails), true, new Dictionary<string, object>
            {
                { "selectedProduct", selectedProduct }
            });
        }
    }
}
