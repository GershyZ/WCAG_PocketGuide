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
    public partial class CriterionContentPage : ContentPage
    {
        public ObservableCollection<Criteria> Criterion { get; set; }
        public CriterionContentPage()
        {
            InitializeComponent();
            Title = "All Criterion";
            Criterion = new ObservableCollection<Criteria>(App.WCAG_Structure.Criterion);
            CriterionListView.ItemsSource = Criterion;
        }
        public CriterionContentPage(Guideline guideline)
        {
            InitializeComponent();
            Title = guideline.Heading;
            Criterion = new ObservableCollection<Criteria>(guideline.Criterion);
            CriterionListView.ItemsSource = Criterion;
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
