
using Test.ViewModels;
namespace Test
{
	public partial class Dashboard : ContentPage
	{
		private DashboardViewModel vm;

		public Dashboard()
		{
			InitializeComponent();

			this.BindingContext = vm = new DashboardViewModel();
		}
	}	
}