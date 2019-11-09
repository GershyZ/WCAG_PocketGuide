using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WCAG_PocketGuide.Views;
using System.Collections.Generic;
using WCAG_PocketGuide.Models;

namespace WCAG_PocketGuide
{
    public partial class App : Application
    {
        private static WCAG _wcag = new WCAG();
        public static string VERSION = "2.0";
        public static Filters.WCAGLevel STRICTNESS = Filters.WCAGLevel.A;
        public static List<Filters.AudienceType> AUDIENCE;
        public static WCAG WCAG_Structure {get { return _wcag; } }

        public App()
        {
            InitializeComponent();         
            MainPage = new NavigationPage(new MainMenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

            

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
