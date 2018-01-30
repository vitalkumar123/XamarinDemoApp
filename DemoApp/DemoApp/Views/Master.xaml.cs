using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoApp.MenuItems;

namespace DemoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public List<MasterPageItem> menuList1 { get; set; }
        public Master ()
		{
            InitializeComponent ();
            Detail = new NavigationPage(new Home());
            IsPresented = false;
            menuList = new List<MasterPageItem>();
            menuList1 = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(Home) };
            var page2 = new MasterPageItem() { Title = "Bills and Payments", Icon = "account.png", TargetType = typeof(BillsandPayments) };
            var page3 = new MasterPageItem() { Title = "My Usage", Icon = "globb.png", TargetType = typeof(MyUsage) };
            var page4 = new MasterPageItem() { Title = "Logout", Icon = "logout.png", TargetType = typeof(Login) };
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList1.Add(page4);
            navigationList.ItemsSource = menuList;
            navigationList1.ItemsSource = menuList1;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

        void OnHome_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Home());
            IsPresented = false;
        }
        void OnBillandPayments_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BillsandPayments());
            IsPresented = false;
        }
        
        void MyUsage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MyUsage());
            IsPresented = false;
        }
    }
}

