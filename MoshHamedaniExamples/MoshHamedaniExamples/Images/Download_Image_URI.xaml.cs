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
    public partial class Download_Image_URI : ContentPage
    {
        public Download_Image_URI()
        {
            InitializeComponent();
            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false; //Cashing Enabled is a boolean to define if once the image is downloaded it remains in memory for next 24 hours or not
            //imageSource.CacheValidity = TimeSpan.FromHours(1);// CashValidity is the TimeSpan during which the downloaded image will remain in memory if cachingenabled is true
            image.Source = imageSource;
            
        }
    }
}