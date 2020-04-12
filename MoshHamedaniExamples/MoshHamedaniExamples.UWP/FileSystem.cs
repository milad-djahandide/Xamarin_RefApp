using System;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(MoshHamedaniExamples.UWP.FileSystem))]
namespace MoshHamedaniExamples.UWP
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var storageFile = await localFolder.CreateFileAsync(fileName);
            await FileIO.WriteTextAsync(storageFile, text);
        }
    }
}
