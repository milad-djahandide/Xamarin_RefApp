using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Show_PopUps : ContentPage
    {
        public Show_PopUps()
        {
            InitializeComponent();
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Selected", response + " is selected", "OK");
               

        }

        private async void btnShowAlert_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Alert", "Are you ready?", "Yes","No");
            if(response)
            {
                await DisplayAlert("Response", "You are ready", "ok");
            }
        }
    }
}