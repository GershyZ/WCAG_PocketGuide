﻿using System;
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
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Principle> wcag { get; set; }

        public MainPage()
        {
            InitializeComponent();

            wcag = new ObservableCollection<Principle>(App.WCAG_Structure.Principles);

            PrinciplesListView.ItemsSource = wcag;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped",((Grouping)e.Item).Name + " was tapped.", "OK");

            await Navigation.PushAsync(new PrincipleContentPage((Principle)e.Item));
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
            
        }
    }
}
