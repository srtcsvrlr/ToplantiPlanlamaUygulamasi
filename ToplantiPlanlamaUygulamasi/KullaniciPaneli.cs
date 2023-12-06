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
            if (e.ClickedItem.Name.Equals("ToplantiOlustur"))
            {
                //label1.Text = e.ClickedItem.Name;
                ToplantiOlustur objForm = new ToplantiOlustur();
                objForm.TopLevel = false;
                pnlKullanici.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
            else {
                //label1.Text = e.ClickedItem.Name;
                ToplantiSec objForm = new ToplantiSec();
                objForm.TopLevel = false;
                pnlKullanici.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
        }
    }
}
