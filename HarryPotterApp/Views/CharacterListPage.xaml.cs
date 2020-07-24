using HarryPotterApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HarryPotterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterListPage : ContentPage
    {
        
        public CharacterListPage()
        {
            InitializeComponent();

        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Character)layout.BindingContext;
            await Navigation.PushAsync(new CharacterPage(item));
        }
    }
}