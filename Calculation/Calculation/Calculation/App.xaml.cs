﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Calculation.Services;
using Calculation.Views;

namespace Calculation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();            
        }

        protected override void OnStart()
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
