using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyMAUI.ViewModel;

[QueryProperty("Text", "Text")]
public partial class DetailViewModel: ObservableObject
{
    [ObservableProperty]
    private string text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
