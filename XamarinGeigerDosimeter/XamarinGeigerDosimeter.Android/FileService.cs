using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XamarinGeigerDosimeter.Droid;
using XamarinGeigerDosimeter.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace XamarinGeigerDosimeter.Droid
{
    public class FileService : IFileService
    {
        public string GetRootPath()
        {
            return Application.Context.GetExternalFilesDir(null).ToString();
        }

        public void CreateFile(string message)
        {
            var fileName = "test-file.txt";
            var destinationPath = Path.Combine(GetRootPath(), fileName);

            File.WriteAllText(destinationPath, message);
        }

    }
}