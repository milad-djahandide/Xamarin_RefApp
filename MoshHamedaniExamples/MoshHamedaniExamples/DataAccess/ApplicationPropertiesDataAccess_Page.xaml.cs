using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPropertiesDataAccess_Page : ContentPage
    {
        public ApplicationPropertiesDataAccess_Page()
        {
            InitializeComponent();
            BindingContext = Application.Current;
        }
    }
}