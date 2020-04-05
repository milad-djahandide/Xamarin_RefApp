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
    public partial class Grouped_List : ContentPage
    {
        public Grouped_List()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactGroup>
            { 
                new ContactGroup("S", "S"){ new Contact() { Name = "Sedigh", Status = "Maryam" } },
                new ContactGroup("M", "M"){ new Contact() { Name = "Jahandide", Status = "Milad" } }
            };
        }
    }
}