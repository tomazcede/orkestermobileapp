using Orkesterapp.Classes;
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
        public Member(User u)
        {
            welcomelabel.Text = "Welcome " + u.firstMidName;
            InitializeComponent();
        }

        public void displayPerformances(int id)
        {

        }
    }
}