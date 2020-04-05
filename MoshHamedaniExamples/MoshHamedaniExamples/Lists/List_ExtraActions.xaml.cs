using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List_ExtraActions : ContentPage
    {
        public List_ExtraActions()
        {
            InitializeComponent();
            listView_TapHandling.ItemsSource = new List<Contact>
            {
                new Contact() { Name = "Sedigh", Status = "Maryam" } ,
                new Contact() { Name = "Jahandide", Status = "Milad" } 
            };
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Selected", "Hello", "OK", "Cancel");
            });
        }

        private void listView_TapHandling_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Selected", contact.Name, "OK","Cancel");
            });
            listView_TapHandling.SelectedItem = null;
        }

        private void listView_TapHandling_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Tapped", contact.Name, "OK","Cancel");
            });

        }
    }
}