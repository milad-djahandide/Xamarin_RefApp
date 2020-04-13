using PCLStorage;
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
    public partial class PclStorage_Page : ContentPage
    {
        public PclStorage_Page()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("MySubFolder",
                CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync("myText.txt",
                CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync(editor.Text);
        }
    }
}