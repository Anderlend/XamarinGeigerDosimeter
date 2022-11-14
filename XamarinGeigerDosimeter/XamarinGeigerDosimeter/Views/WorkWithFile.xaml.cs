using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGeigerDosimeter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkWithFile : ContentPage
    {
        public WorkWithFile()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);

            InitializeComponent();

            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            var writeFileBTN = new Button { Text = "write file", TextColor = Color.FromHex("#77d065"), FontSize = 20, BackgroundColor = Color.Green};
            layout.Children.Add(writeFileBTN);
            this.Content = layout;
        }
    }
}