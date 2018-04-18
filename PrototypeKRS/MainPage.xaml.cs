using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PrototypeKRS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Person PLogin = new Person();
        ProsesLogin x = new ProsesLogin();
        public MainPage()
        {
            HomeMain HM = new HomeMain();
            
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {

            if (tbUsername.Text != "" && tbPassword.Password != "")
            {
                PLogin.username = tbUsername.Text;
                PLogin.password = tbPassword.Password;
                PLogin = x.DataTaker(PLogin.username, PLogin.password);
                if(PLogin.loginsukses == true)
                    Frame.Navigate(typeof(HomeMain), PLogin);
                else if(PLogin.loginsukses == false)
                    tbNotice.Text = "Maaf, Username atau Password anda salah";
            }
            else {
                tbNotice.Text = "Maaf, harap lengkapi seluruh data";
            }
        }

    }

}
