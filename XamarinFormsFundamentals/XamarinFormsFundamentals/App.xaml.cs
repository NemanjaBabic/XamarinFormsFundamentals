﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuotePage();
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
