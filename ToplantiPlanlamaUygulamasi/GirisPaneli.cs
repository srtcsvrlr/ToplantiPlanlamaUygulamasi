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

        // TO DO örnek





        public string ReadUserData()
        {
            return DosyaIslemleri.ReadData("Ali", "KullaniciBilgileri.txt");
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
            //lblGiris.Text = string.Empty;
            //string kullaniciAdi = txtKullaniciAdi.Text;
            //string sifre = txtSifre.Text;
            ////WriteData(kullaniciAdi , sifre);
            //string jsonKullaniciBilgisi = ReadUserData();
            //Kullanici user = JsonConvert.DeserializeObject<Kullanici>(jsonKullaniciBilgisi);




            //if (!(kullaniciAdi == user.Name && sifre == user.Password))
            //{
            //    lblGiris.Text = "Giriþ Baþarsýz!";
            //    return;
            //}
            this.Hide();

            KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
            kullaniciPaneli.Show();

        }
    }
}