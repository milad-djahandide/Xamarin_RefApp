using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoshHamedaniExamples
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Xaml_Examples.Component_Binding());
        }

        private async void btnDifferentDevices_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Xaml_Examples.Dealing_Different_Devices());
        }

        private async void btnAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Layout_Examples.AbsoluteLayout_Example());
        }

        private async void btnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Layout_Examples.RelativeLayout_Example());
        }

        private async void btnImageFromUri_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Images.Download_Image_URI());
        }

        private async void btnImageEmbedded_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Images.Emedded_Image());
        }

        private async void btnPlatformImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Images.PlatformSpecific_Images());
        }

        private async void btnRoundedImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Images.RoundImage());
        }

        private async void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lists.Simple_List());
        }

        private async void btnGroupedList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lists.Grouped_List());
        }

        private async void btnListExtraActions_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lists.List_ExtraActions());
        }


        private async void btnHierarchicalNavigation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.Hierarchical_Navigation());
        }

        private async void btnSimpleMasterDetail_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.Simple_MasterDetail.ContactsPage());
        }

        private async void btnMasterDetail_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.MasterDetail.ContactMasterDetail());
        }

        private async void btnTabbedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.Tabbed_Page());
        }

        private async void btnCarousalPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.Carosal_Page());
        }

        private async void btnDisplayAlerts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.Show_PopUps());
        }

        private async void btnToolbarItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigations.ToolbarItems_Page());
        }

        private async void btnSimpleInputs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forms.Simple_input());
        }

        private async void btnEditorInput_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forms.Editor_Input());
        }

        private async void btnDateTime_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forms.DateNTimePickers());
        }
    }
}
