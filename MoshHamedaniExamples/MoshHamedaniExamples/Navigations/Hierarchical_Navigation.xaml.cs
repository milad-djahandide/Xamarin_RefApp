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
    public partial class Hierarchical_Navigation : ContentPage
    {
        public Hierarchical_Navigation()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hierarchical_Navigation_Page2());
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void btnModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Modal_Page());
        }
    }
}