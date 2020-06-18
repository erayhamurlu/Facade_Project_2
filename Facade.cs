using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace YazilimMimarisiFinal
{
    class Facade
    {
        private DurakKontrol durakkontrol; // Private referanslarimiz
        private OtobusKontrol otobuskontrol; // Private referanslarimiz
        private Konum konum; // Private referanslarimiz
        /// <summary>
        /// Constructor ile gerekli classlarimizi olusturuyoruz
        /// </summary>
        public Facade()
        {
            durakkontrol = new DurakKontrol();
            otobuskontrol = new OtobusKontrol();
            konum = new Konum();
        }
        /// <summary>
        /// Gerekli kontrolleri yapip konum bilgilerini getirecek olan fonksiyonumuz
        /// </summary>
        public void KonumBilgisiniGoster(Otobus o,Durak d)
        {
            if (otobuskontrol.Kontrol(o.OtobusNo) && durakkontrol.Kontrol(d.DurakAdi)) //  Arac ve durak durumunu kontrol ediyoruz
            {
                konum.KonumBilgisiniGoster(o.OtobusNo, d.DurakAdi); // Kosullar saglaniyor ise konum bilgilerini istiyoruz
                Form1.pictureBoxA.Image = Image.FromFile("images//yesiltik.png"); // Arac durumu pozitif ise yesiltik doner
                Form1.pictureBoxD.Image = Image.FromFile("images//yesiltik.png"); // Durak durumu pozitif ise yesiltik doner
            }
            else if (otobuskontrol.Kontrol(o.OtobusNo)) // Aracta problem var ise gerekli bildirim yapiliyor
            {
                MessageBox.Show("Ulasim Araci Faal Değil");
            }
            else if (durakkontrol.Kontrol(d.DurakAdi)) // Durakta problem var ise gerekli bildirim yapiliyor
            {
                MessageBox.Show("Durak Faal Değil");
            }
            else // Hem arac hem durakta sorun var ise gerekli bildirim yapiliyor
            {
                MessageBox.Show("Ulasim Araci ve Durak Faal Değil");
            }
        }
        

    }
}
