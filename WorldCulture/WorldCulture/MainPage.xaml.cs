using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorldCulture
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("world.jpg");
            aboutlist.ItemsSource = GetMenuItems();
            var homePage = typeof(Views.HomePage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenu> GetMenuItems()
        {
            var list = new List<MasterMenu>();
            list.Add(new MasterMenu() 
            { 
                Text = "Native Americans",
                Detail = "Native American culture test",
                ImagePath = "usa.jpg",
                TargetPage = typeof(Views.America)
            });


            return list;
        }

        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenu)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
