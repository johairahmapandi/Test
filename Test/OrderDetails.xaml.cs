using Test.ViewModels;
using Test.Models;

namespace Test
{
    public partial class OrderDetails : ContentPage
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        private void OnAddToCartClicked(object sender, EventArgs e)
        {
            // Add logic here (e.g., add product to cart)
            DisplayAlert("Success", "Item added to cart!", "OK");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.TryGetValue("selectedProduct", out var productObj) && productObj is ProductModel selectedProduct)
            {
                BindingContext = new OrderDetailsViewModel
                {
                    Name = selectedProduct.Name,
                    Description = selectedProduct.Description,
                    Price = (double)selectedProduct.Price
                };
            }
        }
    }
}

