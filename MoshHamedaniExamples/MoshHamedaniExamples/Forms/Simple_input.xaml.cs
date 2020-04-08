using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simple_input : ContentPage
    {
        public Simple_input()
        {
            InitializeComponent();
        }

        private async void switch_Toggled(object sender, ToggledEventArgs e)
        {
            await DisplayAlert("Alert", "Switch is :" + (e.Value ? "on" : "off"), "OK");
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblCompleted.IsVisible = false;
            lblPassValue.Text = "Pasword is: " + e.NewTextValue;
        }

        private void txtPass_Completed(object sender, EventArgs e)
        {
            lblCompleted.IsVisible = true;
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            await DisplayAlert("Selection Changed", pkrContactMethod.SelectedItem.ToString(), "OK");
        }

    }

}