using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplantiPlanlamaUygulamasi
{
    public partial class KullaniciPaneli : Form
    {
        public Kullanici _kullanici { get; set; }
        public KullaniciPaneli(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {

            if (_kullanici.Name != "yonetici")
            {
                menuStrip1.Items["ToplantiOlustur"].Visible = false;
                this.Text = "Toplantı Düzenleme Uygulaması || Kullanıcı Paneli(" + _kullanici.Name + ")";
            }
            else
            {
                this.Text = "Toplantı Düzenleme Uygulaması || Yönetici Paneli";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lstToplantiTarihleri.Items.Add(e.Start.ToShortDateString());
        }

        private void toplantiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pnlKullanici.Controls.Clear();
            switch (e.ClickedItem.Name)
            {
                case "ToplantiOlustur":
                    {
                        ToplantiOlustur objForm = new ToplantiOlustur();
                        objForm.TopLevel = false;
                        pnlKullanici.Controls.Add(objForm);
                        objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        objForm.Dock = DockStyle.Fill;
                        objForm.Show();
                    }
                    break;
                case "ToplantiBilgileri":
                    {
                        ToplantiBilgileri objForm = new ToplantiBilgileri(_kullanici);
                        objForm.TopLevel = false;
                        pnlKullanici.Controls.Add(objForm);
                        objForm.FormBorderStyle = FormBorderStyle.None;
                        objForm.Dock = DockStyle.Fill;
                        objForm.Show();
                    }
                    break;


            }


        }
    }
}
