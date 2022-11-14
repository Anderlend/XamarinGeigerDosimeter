using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGeigerDosimeter.Interface;

namespace XamarinGeigerDosimeter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ////Button timerButton;
        ////bool alive = true;
        //    public HomePage()
        //    {
        //        timerButton = new Button
        //        {
        //            VerticalOptions = LayoutOptions.Center,
        //            HorizontalOptions = LayoutOptions.Center,
        //            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
        //        };
        //        timerButton.Clicked += TimerButton_Clicked;

        //        Content = timerButton;

        //        DisplayTime();
        //    }
        //    private async void DisplayTime()
        //    {
        //        while (alive)
        //        {
        //            timerButton.Text = DateTime.Now.ToString("T");
        //            await Task.Delay(1000);
        //        }
        //    }
        //    private void TimerButton_Clicked(object sender, EventArgs e)
        //    {
        //        if (alive == true)
        //        {
        //            alive = false;
        //        }
        //        else
        //        {
        //            alive = true;
        //            DisplayTime();
        //        }
        //    }
        //}
        public HomePage()
        {
            //SetValue(NavigationPage.HasNavigationBarProperty, false);

            InitializeComponent();

            //var layout = new StackLayout { Padding = new Thickness(5, 10) };
            //var label = new Label { Text = "This is a green label.", TextColor = Color.FromHex("#77d065"), FontSize = 20 };
            //layout.Children.Add(label);
            //this.Content = layout;
        }
            
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new LoginPage()));
        }

        private void SaveText(object sender, EventArgs e)
        {
           var message = TextMessage.Text;

            DependencyService.Get<IFileService>().CreateFile(message);
        }
    }
}