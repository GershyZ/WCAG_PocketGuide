using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCAG_PocketGuide.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WCAG_PocketGuide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
       
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private async void b_getPrinciples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrincipleContentPage());
        }
        private async void b_getCriterion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CriterionContentPage());
        }

        private async void b_playflashcards_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Coming soon", "Creates flash cards using user generated examples", "OK");
        }

        private async void b_export_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Coming soon", "Share examples for more awareness", "OK");

        }
    }
}