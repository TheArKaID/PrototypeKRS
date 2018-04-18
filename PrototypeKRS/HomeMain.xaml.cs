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
using Windows.UI.Popups;
using Windows.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PrototypeKRS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeMain : Page
    {
        
        Person PLogin = new Person();
        string klikPosisi = null;
        public HomeMain()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PLogin = e.Parameter as Person;
            ProsesLogin x = new ProsesLogin();
            var y = PLogin.username;
            var z = PLogin.password;
            //PLogin = x.DataTaker(y, z);
            if (PLogin.loginsukses == true)
            {
                tbNamaAtas.Text = PLogin.username;
            }


        }

        private void btMenuUtama_Click(object sender, RoutedEventArgs e)
        {
            KlikMenuUtama();
        }
        void btDataPembayaran_Click(object sender, RoutedEventArgs e)
        {
            KlikDataPembayaran();
        }
        private void btJadwal_Click(object sender, RoutedEventArgs e)
        {
            KlikJadwal();
        }
        private void btPeraturan_Click(object sender, RoutedEventArgs e)
        {
            KlikPeraturan();
        }
        private void btKuisioner_Click(object sender, RoutedEventArgs e)
        {
            KlikKuisioner();
        }

        private void btBeranda_Click(object sender, RoutedEventArgs e)
        {
            btBeranda.Background = new SolidColorBrush(Color.FromArgb(255, 0, 64, 40));
            this.fMainFrame.Navigate(typeof(ManuUtama));
        }
        private void btRiwayatPembayaran_Click(object sender, RoutedEventArgs e)
        {
            btRiwayatPembayaran.Background = new SolidColorBrush(Color.FromArgb(255, 0, 64, 40));
            this.fMainFrame.Navigate(typeof(FrameRiwayatPembayaran));
        }
    }
}
