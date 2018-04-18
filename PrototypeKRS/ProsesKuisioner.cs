using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrototypeKRS
{
    class ProsesKuisioner
    {
    }
    public sealed partial class HomeMain : Page
    {
        int xPK = 0;
        public void KlikKuisioner()
        {
            if (klikPosisi != "PK" && klikPosisi != null)
            {
                if (lvMenuUtama.Visibility == Visibility.Visible)
                    MenuUtamaHilang();
                if (lvDataPembayaran.Visibility == Visibility.Visible)
                    DataPembayaranHilang();
                if (lvJadwalKuliah.Visibility == Visibility.Visible)
                    JadwalHilang();
                if (lvPeraturan.Visibility == Visibility.Visible)
                    PeraturanHilang();
            }
            klikPosisi = "PK";
            if (xPK % 2 == 0)
                KuisionerMuncul();
            else
            {
                KuisionerHilang();
            }
        }
        void KuisionerMuncul()
        {
            lvKuisioner.Visibility = Visibility.Visible;
            xPK++;
        }
        void KuisionerHilang()
        {
            lvKuisioner.Visibility = Visibility.Collapsed;
            xPK++;
            klikPosisi = null;
        }
    }
}
