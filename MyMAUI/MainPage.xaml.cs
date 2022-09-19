

using MyMAUI.ViewModel;

namespace MyMAUI;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
    
}