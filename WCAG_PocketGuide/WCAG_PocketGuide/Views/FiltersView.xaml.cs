using System        ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCAG_PocketGuide;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WCAG_PocketGuide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FiltersView : ContentView
    {
        public FiltersView()
        {
            InitializeComponent();
            p_Strict.ItemsSource = new List<Filters.WCAGLevel>{ Filters.WCAGLevel.A, Filters.WCAGLevel.AA, Filters.WCAGLevel.AAA };          
        }
        private void sw_Version_Toggled(object sender, ToggledEventArgs e)
        {
            App.VERSION = "2.0";
            if (((Switch)sender).IsToggled)
            {
                App.VERSION = "2.1";
            }
        }

        private void b_filter_Clicked(object sender, EventArgs e)
        {
            sl_filters.IsVisible = !sl_filters.IsVisible;
        }

        private void p_Strict_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            App.STRICTNESS = (Filters.WCAGLevel)((Picker)sender).SelectedItem;            
        }
    }
}