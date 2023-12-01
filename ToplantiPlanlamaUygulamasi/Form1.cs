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
        public  void WriteData(string str, string sifre)
        {
            //StreamWriter sw = new StreamWriter(kullaniciAdi + ".txt", true);

            StreamWriter sw = new StreamWriter("dosyalar/Ali.txt");




            // To write a line in buffer 
            sw.WriteLine(str);

            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();
        }
        public void ReadData()
        {
            string aliPath = @"dosyalar\Ali";
            StreamReader sr = new StreamReader(Path.Combine(aliPath, "KullaniciBilgileri.txt"));

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();

            // To read the whole file line by line 
            lblGiris.Text = str;
            // to close the stream 
            sr.Close();
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            lblGiris.Text = string.Empty;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            //WriteData(kullaniciAdi , sifre);
            string jsonKullaniciBilgisi = ReadUserData();
            Kullanici user = JsonConvert.DeserializeObject<Kullanici>(jsonKullaniciBilgisi);

            if (!(kullaniciAdi == user.Name && sifre == user.Password)) 
            {
                lblGiris.Text = "Giriþ Baþarsýz!";
            }
            this.Hide();

            KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
            kullaniciPaneli.Show();
        }

        public string ReadUserData()
        {
            return "{ \"name\": \"Ali\",\"password\": \"123ali\" }";
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

       
    }
}