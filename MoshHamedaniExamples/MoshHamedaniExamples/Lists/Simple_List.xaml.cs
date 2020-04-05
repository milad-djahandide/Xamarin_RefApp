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
    public partial class Simple_List : ContentPage
    {
        public Simple_List()
        {
            InitializeComponent();

            var contacts = new List<Contact>
            {
                new Contact{Name="Miad", Status="I'm the best", ImageURI="http://placekitten.com/400/300"},
                new Contact{Name="Maryam", Status="She is my only love", ImageURI="http://placekitten.com/400/400"}
            };
            list.ItemsSource = list2.ItemsSource = contacts;
        }
    }
}