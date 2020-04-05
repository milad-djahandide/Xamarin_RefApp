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
            Xaml_Examples.Component_Binding cmpBindingPage = new Xaml_Examples.Component_Binding();
            content.Content = cmpBindingPage.Content;
        }

        private void btnDifferentDevices_Clicked(object sender, EventArgs e)
        {
            Xaml_Examples.Dealing_Different_Devices dealDifDevs = new Xaml_Examples.Dealing_Different_Devices();
            content.Content = dealDifDevs.Content;
        }

        private void btnAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            Layout_Examples.AbsoluteLayout_Example absLayout = new Layout_Examples.AbsoluteLayout_Example();
            content.Content = absLayout.Content;
        }

        private void btnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            Layout_Examples.RelativeLayout_Example relLayout = new Layout_Examples.RelativeLayout_Example();
            content.Content = relLayout.Content;
        }

        private void btnImageFromUri_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Images.Download_Image_URI()).Content;
        }

        private void btnImageEmbedded_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Images.Emedded_Image()).Content;
        }

        private void btnPlatformImage_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Images.PlatformSpecific_Images()).Content;
        }

        private void btnRoundedImage_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Images.RoundImage()).Content;
        }

        private void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Lists.Simple_List()).Content;
        }

        private void btnGroupedList_Clicked(object sender, EventArgs e)
        {
            content.Content = (new Lists.Grouped_List()).Content;
        }
    }
}
