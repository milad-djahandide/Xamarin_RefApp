using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Emedded_Image : ContentPage
    {
       
        public Emedded_Image()
        {
            InitializeComponent();
            //switch(Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //}
            image.Source = ImageSource.FromResource("MoshHamedaniExamples.Assets.Images.dunkey.jpg", Assembly.GetExecutingAssembly());
            
           
        }
    }
}