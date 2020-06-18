using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiFinal
{
    class Konum
    {
        /// <summary>
        /// Konum bilgilerini dondurecek olan fonksiyonumuz
        /// </summary>
        public bool KonumBilgisiniGoster(string otobusno,string durakadi)
        {
            // Veritabanindan konum bilgisi cekilecek
            Form1.pictureBoxK.Image = Image.FromFile("images//konum.jpg");
            return true;
        }
    }
}
