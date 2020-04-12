using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(MoshHamedaniExamples.iOS.FileSystem))]
namespace MoshHamedaniExamples.iOS
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}