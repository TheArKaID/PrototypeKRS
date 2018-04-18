using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrototypeKRS
{
    class ProsesDataPembayaran
    {
    }
    public sealed partial class HomeMain : Page
    {
        int xDP = 0;
        public void KlikDataPembayaran()
        {
            if (klikPosisi != "DP" && klikPosisi != null)
            {
                if (lvMenuUtama.Visibility == Visibility.Visible)
                    MenuUtamaHilang();
                if (lvJadwalKuliah.Visibility == Visibility.Visible)
                    JadwalHilang();
                if (lvPeraturan.Visibility == Visibility.Visible)
                    PeraturanHilang();
                if (lvKuisioner.Visibility == Visibility.Visible)
                    KuisionerHilang();
            }
            klikPosisi = "DP";
            if (xDP % 2 == 0)
                DataPembayaranMuncul();
            else
            {
                DataPembayaranHilang();
            }
        }
        void DataPembayaranMuncul()
        {
            lvDataPembayaran.Visibility = Visibility.Visible;
            xDP++;
        }
        void DataPembayaranHilang()
        {
            lvDataPembayaran.Visibility = Visibility.Collapsed;
            xDP++;
            klikPosisi = null;
        }
    }
}
