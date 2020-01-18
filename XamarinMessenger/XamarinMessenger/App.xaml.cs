﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMessenger.Services;
using XamarinMessenger.Views;

namespace XamarinMessenger
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<DataStore>();
            MainPage = new MainPage();
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
