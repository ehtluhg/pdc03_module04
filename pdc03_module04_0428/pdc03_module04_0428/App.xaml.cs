﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_module04_0428
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());
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
