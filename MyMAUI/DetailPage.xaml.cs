using MyMAUI.ViewModel;

namespace MyMAUI;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}
