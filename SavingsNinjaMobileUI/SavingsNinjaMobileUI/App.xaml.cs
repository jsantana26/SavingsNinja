﻿using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using SavingsNinjaMobileUI.ViewModels;
using Xamarin.Forms;

namespace SavingsNinjaMobileUI
{
    

    public class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            // TODO: Register additional viewmodels and services
            container
                .PerRequest<HomeViewModel>();

            Initialize();

            DisplayRootViewFor<MainViewModel>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
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