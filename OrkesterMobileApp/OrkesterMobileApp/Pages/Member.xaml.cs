using Orkesterapp.Classes;
using OrkesterMobileApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrkesterMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Member : ContentPage
    {
        private OrkesterApi api = new OrkesterApi();
        public Member()
        {
            InitializeComponent();

            welcomelabel.Text = "Hello " + App.loggedIn.firstMidName + " " + App.loggedIn.lastName;
            displayPerformances();
        }

        public async void displayPerformances()
        {
            List<Performance> perfs = await api.GetPerformances(App.loggedIn.orchesterID);

            performanceListView.ItemsSource = perfs;
        }
    }
}