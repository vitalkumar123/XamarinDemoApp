using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{           
            InitializeComponent ();
            //var lpg = new Login();
            //NavigationPage.SetHasBackButton(lpg, false);
            //NavigationPage.SetHasNavigationBar(lpg, false);
        }

        void login_Click(object sender, EventArgs e)
        {
            var text = uid.Text;
            var text1 = pwd.Text;
            if (text == "admin" && text1=="admin")
            {
                var pg = new Master();
                Navigation.PushAsync(pg);
                NavigationPage.SetHasBackButton(pg, false);
                NavigationPage.SetHasNavigationBar(pg, false);
            }
            else
            {
                //lblmsg.Text = "* Please Enter valid Credentials";
                DisplayAlert("Alert", "Incorrect Credetials", "OK");
            }
        }
    }
}