using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformSpecific_Images : ContentPage
    {
        public PlatformSpecific_Images()
        {
            InitializeComponent();

            btn3.ImageSource = ImageSource.FromFile(Device.RuntimePlatform == Device.UWP ? "Images/clock.png" : "clock.png");
        }
    }
}