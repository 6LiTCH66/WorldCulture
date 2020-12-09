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
    public partial class China : ContentPage
    {
        RadioButton[] radioButtons = new RadioButton[3];
        Label lbl, lbl1;
        Button btn;
        StackLayout stack;
        string[] s = new string[] { "Dragon Boat Festival", "Chinese New Year", "Mid-Autumn Festival" };
        public China()
        {
            Title = "China";
            stack = new StackLayout();

            lbl = new Label
            {
                Text = "During which traditional festival do the Chinese offer sacrifices to the moon - such as mooncakes and symbolic fruits - to bring them good luck?",
                Margin = new Thickness(20),
                FontAttributes = FontAttributes.Bold,
                FontSize = 25,
                TextColor = Color.Black,
            };
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i] = new RadioButton() { Text = s[i] };
                stack.Children.Add(radioButtons[i]);
                radioButtons[i].CheckedChanged += China_CheckedChanged;
            }
            btn = new Button
            {
                Text = "Check answer",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 85,
            };

            lbl1 = new Label
            {
                Text = "Your answer: ",
                IsVisible = false,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn.Clicked += Btn_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, stack, lbl1, btn}
            };
            Content = stackLayout;
        }

        string qu;
        private void China_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            qu = (sender as RadioButton).Text;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            if (radioButtons[2].IsChecked)
            {
                lbl1.IsVisible = true;
                lbl1.TextColor = Color.Green;
                lbl1.Text = "Your answer: " + radioButtons[2].Text;

            }
            else
            {
                lbl1.IsVisible = true;
                lbl1.TextColor = Color.Red;
                lbl1.Text = "Your answer: " + qu;
            }
        }

        
    }
}