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
    public partial class GuidelineContentPage : ContentPage
    {
        public ObservableCollection<Guideline> Guidelines { get; set; }

        public GuidelineContentPage(Principle principle)
        {
            InitializeComponent();
            Guidelines = new ObservableCollection<Guideline>(principle.Guidelines);
            Title = principle.Heading;
            GuidelineListView.ItemsSource = Guidelines;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;            
            await Navigation.PushAsync(new CriterionContentPage((Guideline)e.Item));
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}