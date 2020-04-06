using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Navigations.Simple_MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new ObservableCollection<Contact>
            {
                new Contact() { Name = "Sedigh", Status = "Maryam" } ,
                new Contact() { Name = "Jahandide", Status = "Milad" }
            };
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new ContactDetailPage(e.SelectedItem as Contact));
            listView.SelectedItem = null;
        }
    }
}