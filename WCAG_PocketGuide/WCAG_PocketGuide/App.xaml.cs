using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WCAG_PocketGuide.Views;

namespace WCAG_PocketGuide
{
    public partial class App : Application
    {
        private static WCAG _wcag = new WCAG();

        public static WCAG WCAG_Structure {get { return _wcag; } }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PrincipleContentPage());
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
