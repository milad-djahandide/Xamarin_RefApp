using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateNTimePickers : ContentPage
    {
        public DateNTimePickers()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}