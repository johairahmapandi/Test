using System.Collections.ObjectModel;

namespace Test;

public partial class Orders : ContentPage
{
    public ObservableCollection<OrderItem> OrderItems { get; set; }
    public double TotalAmount => OrderItems.Sum(item => item.TotalPrice);

    public Orders()
	{
		InitializeComponent();
        OrderItems = new ObservableCollection<OrderItem>
        {
            new OrderItem { Name = "Heart Earrings", Price = 300.00, Quantity = 1, Image = "jewelry1.png" },
            new OrderItem { Name = "Ruby Black Sandals", Price = 900.00, Quantity = 1, Image = "shoe2.png" },
            new OrderItem { Name = "Pink Leather Watch", Price = 1200.00, Quantity = 1, Image = "jewelry3.png" }
        };
        BindingContext = this;
    }
    private async void OnPlaceOrderClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Order Placed", "Your order has been successfully placed!", "OK");
        // Navigate to a confirmation page or clear the cart
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
public class OrderItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Image { get; set; }
    public double TotalPrice => Price * Quantity;
}

