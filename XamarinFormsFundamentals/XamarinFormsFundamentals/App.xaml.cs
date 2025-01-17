﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFundamentals.FormsAndSettingPages;
using XamarinFormsFundamentals.Navigation;

namespace XamarinFormsFundamentals
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new HierarchicalNavigationWelcomePage())
            //{
            //    BarBackgroundColor = Color.DarkGray,
            //    BarTextColor = Color.White,
            //};

            MainPage = new NavigationPage(new TableViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
