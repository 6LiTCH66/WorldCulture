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

            list.Add(new MasterMenu()
            {
                Text = "Japan",
                Detail = "Japan Culture",
                ImagePath = "japan.jpg",
                TargetPage = typeof(Views.Japan)
            });

            list.Add(new MasterMenu()
            {
                Text = "China",
                Detail = "China Culture",
                ImagePath = "china.jpg",
                TargetPage = typeof(Views.China)
            });

            list.Add(new MasterMenu()
            {
                Text = "Brazil",
                Detail = "Brazil Culture",
                ImagePath = "brazil.jpg",
                TargetPage = typeof(Views.Brazil)
            });
            
            list.Add(new MasterMenu()
            {
                Text = "Russia",
                Detail = "Russia Culture",
                ImagePath = "russia.jpg",
                TargetPage = typeof(Views.Russia)
            });
            list.Add(new MasterMenu()
            {
                Text = "Ireland",
                Detail = "Irish Culture",
                ImagePath = "Irish.jpg",
                TargetPage = typeof(Views.Ireland)
            });
            list.Add(new MasterMenu()
            {
                Text = "Norwegian",
                Detail = "Norwegian Culture",
                ImagePath = "Norwegian.jpg",
                TargetPage = typeof(Views.Norwegian)
            });
            list.Add(new MasterMenu()
            {
                Text = "German",
                Detail = "German Culture",
                ImagePath = "German.jpg",
                TargetPage = typeof(Views.German)
            });
            list.Add(new MasterMenu()
            {
                Text = "Italy",
                Detail = "Italy Culture",
                ImagePath = "Italy.jpg",
                TargetPage = typeof(Views.Italy)
            });
            list.Add(new MasterMenu()
            {
                Text = "Spain",
                Detail = "Spanish Culture",
                ImagePath = "spain.jpg",
                TargetPage = typeof(Views.Spain)
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
