using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrototypeKRS
{
    class ProsesJadwal
    {
    }
    public sealed partial class HomeMain : Page
    {
        int xJ = 0;
        public void KlikJadwal()
        {
            if (klikPosisi != "J" && klikPosisi != null)
            {
                if (lvMenuUtama.Visibility == Visibility.Visible)
                    MenuUtamaHilang();
                if (lvDataPembayaran.Visibility == Visibility.Visible)
                    DataPembayaranHilang();
                if (lvPeraturan.Visibility == Visibility.Visible)
                    PeraturanHilang();
                if (lvKuisioner.Visibility == Visibility.Visible)
                    KuisionerHilang();
            }
            klikPosisi = "J";
            if (xJ % 2 == 0)
                JadwalMuncul();
            else
            {
                JadwalHilang();
            }
        }
        void JadwalMuncul()
        {
            lvJadwalKuliah.Visibility = Visibility.Visible;
            xJ++;
        }
        void JadwalHilang()
        {
            lvJadwalKuliah.Visibility = Visibility.Collapsed;
            xJ++;
            klikPosisi = null;
        }
    }
}
