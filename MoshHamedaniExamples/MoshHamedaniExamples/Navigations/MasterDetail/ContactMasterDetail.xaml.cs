using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Navigations.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMasterDetail : MasterDetailPage
    {
        public ContactMasterDetail()
        {
            InitializeComponent();
            listView.ItemsSource = new ObservableCollection<Contact>
            {
                new Contact() { Name = "Sedigh", Status = "Maryam" } ,
                new Contact() { Name = "Jahandide", Status = "Milad" }
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Detail = new Simple_MasterDetail.ContactDetailPage(e.SelectedItem as Contact);
            IsPresented = false;
        }
    }
}