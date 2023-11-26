using System.Runtime.InteropServices;

namespace ToplantiPlanlamaUygulamasi
{
    public partial class frmToplantiUygulamasi : Form
    {
        public frmToplantiUygulamasi()
        {
            InitializeComponent();
        }


        public  void WriteData(string str, string sifre)
        {
            //StreamWriter sw = new StreamWriter(kullaniciAdi + ".txt", true);

            StreamWriter sw = new StreamWriter("Ali.txt", true);




            // To write a line in buffer 
            sw.WriteLine(str);

            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();
        }
        public  void ReadData()
        {
            StreamReader sr = new StreamReader("Ali.txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();

            // To read the whole file line by line 
            label1.Text = str;
            // to close the stream 
            sr.Close();
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            WriteData(kullaniciAdi , sifre);
            ReadData();

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