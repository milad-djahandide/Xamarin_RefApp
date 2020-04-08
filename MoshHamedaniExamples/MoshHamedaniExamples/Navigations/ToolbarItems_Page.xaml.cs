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
    public partial class ToolbarItems_Page : ContentPage
    {
        public ToolbarItems_Page()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Toolbar Icon Clicked", "Ok");
        }

    }
}