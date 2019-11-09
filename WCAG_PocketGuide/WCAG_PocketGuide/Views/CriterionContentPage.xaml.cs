using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WCAG_PocketGuide.Helpers;
using WCAG_PocketGuide.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WCAG_PocketGuide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CriterionContentPage : ContentPage
    {
        private static List<Criteria> _criterion;
        public ObservableCollection<Criteria> Criterion
        {
            get
            {
                return new ObservableCollection<Criteria>(CriterionContentPage.APPLYFILTERS());
            }
        }
        public CriterionContentPage()
        {
            InitializeComponent();
            Title = "All Criterion";
            _criterion = App.WCAG_Structure.Criterion;
            CriterionListView.ItemsSource = Criterion;
        }
        public CriterionContentPage(Guideline guideline)
        {
            InitializeComponent();
            Title = guideline.Heading;
            _criterion = guideline.Criterion;
            CriterionListView.ItemsSource = Criterion;
        }
        public static List<Criteria> APPLYFILTERS()
        {
            List<Criteria> filtered = new List<Criteria>();

            foreach (Criteria c in _criterion)
            {
                if (double.Parse(c.Version) <= double.Parse(App.VERSION) && c.Level <= App.STRICTNESS && c.Level != Filters.WCAGLevel.A)
                {
                    filtered.Add(c);
                }
            }
            return _criterion;
        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            try
            {
                var list = JsonConvert.DeserializeObject<List<Criteria>>(Settings.CriteriaSetting);
                foreach (var c in list)
                {
                    if (c.Id.Equals(((Criteria)e.Item).Id))
                    {
                        await (Navigation.PushModalAsync(new CriteriaDetailsPage(c)));
                    }
                }
            } catch (Exception ex) { }

        }
    }
}