using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WCAG_PocketGuide.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WCAG_PocketGuide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipleContentPage : ContentPage
    {
        public ObservableCollection<Guideline> Guidelines { get; set; }

        public PrincipleContentPage(Principle principle)
        {
            InitializeComponent();

            Guidelines = new ObservableCollection<Guideline>(principle.Guidelines);
            
            GuidelinesListView.ItemsSource = Guidelines;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
