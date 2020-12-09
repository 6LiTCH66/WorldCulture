using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        Image img;
        Label lbl;
        public HomePage()
        {
            img = new Image
            {
                Source = ImageSource.FromFile("worlds.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            lbl = new Label
            {
                Text = "World Culture Quiz",
                FontAttributes = FontAttributes.Bold,
                FontSize = 30,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };

            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { lbl, img  }
            };

            Content = stackLayout2;
        }
    }
}