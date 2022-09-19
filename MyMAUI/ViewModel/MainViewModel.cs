using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyMAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;

        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        private string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh oh", "No Internet", "OK");
                return;
            }

            Items.Add(Text);
            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
            //await Shell.Current.GoToAsync(nameof(DetailPage), new Dictionary<string, object>()
            //{
            //    { nameof(DetailPage), s }
            //});
        }
    }
}

