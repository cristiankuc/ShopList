using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopList.Maui.ViewModels
{
    public partial class EditItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private ShopListItem _Item;
        [RelayCommand]
        public async Task SaveAsync () 
        {
            await Shell.Current.GoToAsync("..");
         }
    }
}
