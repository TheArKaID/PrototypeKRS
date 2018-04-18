using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrototypeKRS
{
    class ProsesMenuUtama
    {
    }
    public class Biodata {
        public string Nama, Alamat, TTL;
    }
    public sealed partial class HomeMain : Page {
        int xMU = 0;
        public void KlikMenuUtama()
        {
            if (klikPosisi != "MU" && klikPosisi != null)
            {
                if(lvDataPembayaran.Visibility == Visibility.Visible)
                    DataPembayaranHilang();
                if (lvJadwalKuliah.Visibility == Visibility.Visible)
                    JadwalHilang();
                if (lvPeraturan.Visibility == Visibility.Visible)
                    PeraturanHilang();
                if (lvKuisioner.Visibility == Visibility.Visible)
                    KuisionerHilang();
            }
            klikPosisi = "MU";
            if (xMU % 2 == 0)
                MenuUtamaMuncul();
            else {
                MenuUtamaHilang();
            }

        }
        void MenuUtamaMuncul() {
            lvMenuUtama.Visibility = Visibility.Visible;
            xMU++;
        }
        void MenuUtamaHilang() {
            lvMenuUtama.Visibility = Visibility.Collapsed;
            xMU++;
            klikPosisi = null;
        }
    }
}
