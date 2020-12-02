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
    public partial class America : ContentPage
    {
        Label lbl;
        RadioButton radi1, radi2, radi3, radi4;

        public America()
        {
           

            lbl = new Label
            {
                Text = "What's your favorite animal?"
            };
            radi1 = new RadioButton
            {
                Text = "Cat",
            };
            radi2 = new RadioButton
            {
                Text = "Dog",
            };
            radi3 = new RadioButton
            {
                Text = "Elephant",
            };
            radi4 = new RadioButton
            {
                Text = "Monkey",
                IsChecked = true,
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children ={lbl, radi1 ,radi2, radi3, radi4}
            };
            Content = stackLayout;
        }
    }
}