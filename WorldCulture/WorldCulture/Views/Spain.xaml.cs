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
    public partial class Spain : ContentPage
    {
        RadioButton[] radioButtons = new RadioButton[4];
        Label lbl, lbl1;
        Button btn;
        StackLayout stack;
        string[] s = new string[] { "Herod", "Christopher Columbus", "Confucius", "Julius Caesar" };
        public Spain()
        {
            stack = new StackLayout();

            lbl = new Label
            {
                Text = "Which figure is more famous in Spanish history?",
                Margin = new Thickness(20),
                FontAttributes = FontAttributes.Bold,
                FontSize = 25,
                TextColor = Color.Black,
            };
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i] = new RadioButton() { Text = s[i] };
                stack.Children.Add(radioButtons[i]);
                radioButtons[i].CheckedChanged += OnCheckedChanged;
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

            btn.Clicked += BtnOnClicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, stack, lbl1, btn }
            };
            Content = stackLayout;
        }
        string qu;
        private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            qu = (sender as RadioButton).Text;
        }

        private void BtnOnClicked(object sender, EventArgs e)
        {
            if (radioButtons[1].IsChecked)
            {
                lbl1.IsVisible = true;
                lbl1.TextColor = Color.Green;
                lbl1.Text = "Your answer: " + radioButtons[1].Text;

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