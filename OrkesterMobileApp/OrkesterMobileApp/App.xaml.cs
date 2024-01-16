using Orkesterapp.Classes;
using Orkesterapp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrkesterMobileApp
{
    public partial class App : Application
    {
        public static User loggedIn;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
