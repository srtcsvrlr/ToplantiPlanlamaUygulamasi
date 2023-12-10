using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace ToplantiPlanlamaUygulamasi
{
    public partial class frmToplantiUygulamasi : Form
    {
        public frmToplantiUygulamasi()
        {
            InitializeComponent();
        }

        // TO DO �rnek

        public string ReadUserData()
        {
            return DosyaIslemleri.ReadData("YoneticiBilgileri.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmToplantiUygulamasi_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            lblGiris.Text = string.Empty;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;


            if (kullaniciAdi == "yonetici")
            {
                string jsonKullaniciBilgisi = ReadUserData();
                Kullanici kullanici = JsonConvert.DeserializeObject<Kullanici>(jsonKullaniciBilgisi);

                if (!(kullaniciAdi == kullanici.Name && sifre == kullanici.Password))
                {
                    lblGiris.Text = "Kullanici Ad� veya �ifre Hatal�!";
                    return;
                }

                this.Hide();
                KullaniciPaneli kullaniciPaneli = new KullaniciPaneli(kullanici);
                kullaniciPaneli.Show();
            }
            else {
                string jsonToplantiBilgileri = ReadToplantiBilgileri();

               var toplanti = JsonConvert.DeserializeObject<Toplanti>(jsonToplantiBilgileri);
                if (toplanti == null)
                {
                    MessageBox.Show("Toplanti Bilgileri Al�namad�.");
                    return;
                }

                if (!toplanti.KatilimciListesi.Any(s => s.Equals(kullaniciAdi)))
                {
                    MessageBox.Show("Toplanti kat�l�mc�lar� aras�nda de�ilsiniz!");
                    return;

                }

                if (toplanti.ToplantiKodu!=sifre)
                {
                    MessageBox.Show("Toplanti kodunu yanl�� girdiniz!");
                    return;

                }
                Kullanici kullanici = new Kullanici();
                kullanici.Name = kullaniciAdi;

                this.Hide();
                KullaniciPaneli kullaniciPaneli = new KullaniciPaneli(kullanici);
                kullaniciPaneli.Show();


            }

           

        }
        public string ReadToplantiBilgileri()
        {
            return DosyaIslemleri.ReadData("ToplantiBilgileri.txt");
        }
    }
}