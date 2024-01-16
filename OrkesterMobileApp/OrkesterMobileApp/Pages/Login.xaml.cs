using Orkesterapp.Classes;
using OrkesterMobileApp;
using OrkesterMobileApp.Classes;
using OrkesterMobileApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Orkesterapp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private OrkesterApi apiClient = new OrkesterApi();
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.loggedIn = await apiClient.GetUser(email.Text, pass.Text);

                switch (App.loggedIn.roleID)
                {
                    case 1:
                        await Navigation.PushAsync(new Member());
                        break;
                    case 2:
                        await Navigation.PushAsync(new Conductor());
                        break;
                    case 3:
                        await Navigation.PushAsync(new Admin());
                        break;
                }

                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
                await DisplayAlert("Alert", "Email and password do not match", "Ok");
            }
        }
    }
}