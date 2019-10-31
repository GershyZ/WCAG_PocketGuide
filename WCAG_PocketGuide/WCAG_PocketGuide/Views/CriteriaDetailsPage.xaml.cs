using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCAG_PocketGuide.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WCAG_PocketGuide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class CriteriaDetailsPage : ContentPage
    {
        private Criteria _criteria;
        public CriteriaDetailsPage(Criteria c)
        {
            _criteria = c;
            BindingContext = _criteria;
            InitializeComponent();
          
        }

        private void b_AddExample_Clicked(object sender, EventArgs e)
        {
            _criteria.Examples.Add(e_example.Text);
            e_example.Text = "";
        }
    }
}