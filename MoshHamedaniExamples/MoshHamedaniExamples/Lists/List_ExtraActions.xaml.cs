using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Contact> _contacts;
        private IEnumerable<Contact> Get_Contacts(string searchText = null)
        {
            var contacts = new ObservableCollection<Contact>
            {
                new Contact() { Name = "Sedigh", Status = "Maryam" } ,
                new Contact() { Name = "Jahandide", Status = "Milad" }
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;
            return contacts.Where(c => c.Name.StartsWith(searchText));
        }
        public List_ExtraActions()
        {
            InitializeComponent();
             _contacts= new ObservableCollection<Contact>
            {
                new Contact() { Name = "Sedigh", Status = "Maryam" } ,
                new Contact() { Name = "Jahandide", Status = "Milad" } 
            };
            listView_TapHandling.ItemsSource =
                listView_ContextAction.ItemsSource = _contacts;

            listView_Refresh.ItemsSource = listView_Searchbar.ItemsSource = Get_Contacts();
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

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Call", contact.Name, "OK");
            });
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void listView_Refresh_Refreshing(object sender, EventArgs e)
        {
            listView_Refresh.ItemsSource = Get_Contacts();
            listView_Refresh.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView_Searchbar.ItemsSource = Get_Contacts(e.NewTextValue);
        }
    }
}