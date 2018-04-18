using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrototypeKRS
{
    class ProsesPeraturan
    {
    }
    public sealed partial class HomeMain : Page
    {
        int xPP = 0;
        public void KlikPeraturan()
        {
            if (klikPosisi != "PP" && klikPosisi != null)
            {
                if (lvMenuUtama.Visibility == Visibility.Visible)
                    MenuUtamaHilang();
                if (lvDataPembayaran.Visibility == Visibility.Visible)
                    DataPembayaranHilang();
                if (lvJadwalKuliah.Visibility == Visibility.Visible)
                    JadwalHilang();
                if (lvKuisioner.Visibility == Visibility.Visible)
                    KuisionerHilang();
            }
            klikPosisi = "PP";
            if (xPP % 2 == 0)
                PeraturanMuncul();
            else
            {
                PeraturanHilang();
            }
        }
        void PeraturanMuncul()
        {
            lvPeraturan.Visibility = Visibility.Visible;
            xPP++;
        }
        void PeraturanHilang()
        {
            lvPeraturan.Visibility = Visibility.Collapsed;
            xPP++;
            klikPosisi = null;
        }
    }
}
