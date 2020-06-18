using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiFinal
{
    public partial class Form1 : Form
    {
        public static PictureBox pictureBoxK; // Konum classindan gelen pictureboxi tutacak degiskenimiz
        public static PictureBox pictureBoxA; // Facade classindan gelen pictureboxi tutacak degiskenimiz
        public static PictureBox pictureBoxD; // Facade classindan gelen pictureboxi tutacak degiskenimiz
        private string otobusno; // Kullanicidan alinan otobusno bilgisini tutacak degiskenimiz
        private string durakadi; // Kullanicidan alinan durakadini tutacak degiskenimiz
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Buttona basildiginda calisacak fonksiyonumuz
        /// </summary>
        private void KonumGoster_Click(object sender, EventArgs e)
        {
            otobusno = comboBoxUlasimTipi.Text; // Kullanıcıdan ulasimtipi bilgisini aliyoruz
            durakadi = comboBoxDurak.Text; // Kullanicidan durak bilgisini aliyoruz
            if (ComboBoxKontrol()) // ComboBox bos mu dolu mu kontrolu yapiyoruz
            {
                Facade fcd = new Facade(); // Facade classimizi olusturuyoruz
                fcd.KonumBilgisiniGoster(new Otobus { OtobusNo = otobusno },new Durak { DurakAdi = durakadi } ); // Aracin konum bilgilerini istiyoruz
            }
        }
        /// <summary>
        /// ComboBox bos mu dolu mu kontrolu yapan fonksiyonumuz
        /// </summary>
        private bool ComboBoxKontrol()
        {
            if(comboBoxUlasimTipi.Text == "" || comboBoxDurak.Text == "") // Null kontrolu
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz"); // Uyari mesaji
                return false;
            }
            else
            {
                return true;
                
            }
        }
        /// <summary>
        /// Form yuklendiginde calisacak fonksiyonumuz
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxK = pictureBoxKonum;
            pictureBoxA = pictureBoxArac;
            pictureBoxD = pictureBoxDurak;
        }
    }
}
