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
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {

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
                case "ToplantiSec":
                    {
                        ToplantiSec objForm = new ToplantiSec();
                        objForm.TopLevel = false;
                        pnlKullanici.Controls.Add(objForm);
                        objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        objForm.Dock = DockStyle.Fill;
                        objForm.Show();
                    }
                    break;
                case "ToplantiBilgileri":
                    {
                        ToplantiBilgileri objForm = new ToplantiBilgileri();
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
