using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Xaml_Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dealing_Different_Devices : ContentPage
    {
        public Dealing_Different_Devices()
        {
            InitializeComponent();
            ////Method1(Simplest)
            //if (Device.RuntimePlatform == Device.iOS )
            //    Padding = new Thickness(0,20,0,0);
            //else if(Device.RuntimePlatform == Device.Android)
            //    Padding = new Thickness(10, 20, 0, 0);
            //else if (Device.RuntimePlatform == Device.UWP)
            //    Padding = new Thickness(30, 20, 0, 0);

            ////Method2(Cleaner)
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case Device.Android:
            //        Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //    case Device.UWP:
            //        Padding = new Thickness(30, 20, 0, 0);
            //        break;
            //}

            ////Method3(Cleanest)
            ////Code is in Xaml File
        }
    }
}