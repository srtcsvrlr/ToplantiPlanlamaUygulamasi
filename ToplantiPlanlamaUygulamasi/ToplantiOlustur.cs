using Newtonsoft.Json;
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
    public partial class ToplantiOlustur : Form
    {
        public ToplantiOlustur()
        {
            InitializeComponent();
        }

        private void ToplantiOlustur_Load(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_MouseMove(object sender, MouseEventArgs e)
        {
            //MonthCalendar.HitTestInfo hit = monthCalendar1.HitTest(e.Location);
            //if (hit.Time == new DateTime(2023, 12, 07))
            //{
            //    toolTip1.SetToolTip(monthCalendar1,"toplanti-1");
            //}

        }

        private void clndrToplantiTarihleri_DateSelected(object sender, DateRangeEventArgs e)
        {
            lsbTarihler.Items.Add(e.Start.ToString("yyyy-MM-dd"));

        }

        private void btnTarihSil_Click(object sender, EventArgs e)
        {
            if (!lsbTarihler.SelectedIndex.Equals(-1))
            {
                lsbTarihler.Items.RemoveAt(lsbTarihler.SelectedIndex);
            }
        }

        private void btnToplantiOlustur_Click(object sender, EventArgs e)
        {
            Toplanti toplanti = new Toplanti()
            {
                Baslik = txtBaslik.Text,
                Aciklama = rctxtAciklama.Text,
                UygunToplantiTarihleri = new List<DateTime>()

            };

            foreach (var item in lsbTarihler.Items)
            {
                var date = Convert.ToDateTime(item.ToString());
                toplanti.UygunToplantiTarihleri.Add(date);
            }
            var jsonData = JsonConvert.SerializeObject(toplanti);
            DosyaIslemleri.WriteData("Ali", "ToplantiBilgisi.txt", jsonData);


        }
    }
}
