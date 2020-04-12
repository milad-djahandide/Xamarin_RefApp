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
    public partial class FileSystem_Page : ContentPage
    {
        public FileSystem_Page()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           var fileSystem = DependencyService.Get<IFileSystem>();
            fileSystem.WriteTextAsync("sampleText.txt", editor.Text);
        }
    }
}