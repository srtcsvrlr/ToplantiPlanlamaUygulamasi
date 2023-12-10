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
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnToplantiOlustur_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Toplantı Başlığı ekleyiniz!");
                return;
            }

            if (lsbKatilimcilar.Items.Count < 1)
            {
                MessageBox.Show("En az 2 adet Katılımcı ekleyiniz!");
                return;
            }

            if (lsbTarihler.Items.Count < 1)
            {
                MessageBox.Show("En az 2 adet Toplantı Tarihi ekleyiniz!");
                return;
            }

            if (lsbKatilimcilar.Items.Count < 1)
            {
                MessageBox.Show("En az 2 adet Katılımcı ekleyiniz!");
                return;
            }


            Toplanti toplanti = new Toplanti()
            {
                Baslik = txtBaslik.Text,
                Aciklama = rctxtAciklama.Text,
                UygunToplantiTarihleri = new List<DateTime>(),
                KatilimciListesi = new List<string>(),
                ToplantiKodu = RandomString(10)

            };

            foreach (var item in lsbTarihler.Items)
            {
                var date = Convert.ToDateTime(item.ToString());
                toplanti.UygunToplantiTarihleri.Add(date);
            }

            foreach (var item in lsbKatilimcilar.Items)
            {
                var katilimci = item.ToString();
                toplanti.KatilimciListesi.Add(katilimci);
            }

            var jsonData = JsonConvert.SerializeObject(toplanti);
            DosyaIslemleri.WriteData("ToplantiBilgileri.txt", jsonData);

            KatilimciBilgileri katilimciBilgileri = new KatilimciBilgileri()
            {
                KatilimciAdi = "default",
                SecilenTarihler = toplanti.UygunToplantiTarihleri
            };

            List<KatilimciBilgileri> katilimciBilgileriListesi = new List<KatilimciBilgileri>()

            var katilimciJson = JsonConvert.SerializeObject(katilimciBilgileri);
            var katilimciBilgileriListesiJson=DosyaIslemleri.ReadData("ToplantiBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                katilimciBilgileriListesi= JsonConvert.DeserializeObject<List<KatilimciBilgileri>(katilimciBilgileriListesiJson);
            }
            DosyaIslemleri.WriteData("ToplantiBilgileri.txt", jsonData);


            MessageBox.Show("Toplantı başarıyla oluşturuldu.");


            this.Hide();

            //KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
            //kullaniciPaneli.Show();

            //ToplantiBilgileri objForm = new ToplantiBilgileri();
            //objForm.TopLevel = false;
            //kullaniciPaneli.Controls["pnlKullanici"].Controls.Add(objForm);
            //objForm.FormBorderStyle = FormBorderStyle.None;
            //objForm.Dock = DockStyle.Fill;
            //objForm.Show();
        }

        private void btnKatimciEkle_Click(object sender, EventArgs e)
        {
            lsbKatilimcilar.Items.Add(txtKatilimci.Text.Trim());
        }


        private void btnKatilimciSil_Click(object sender, EventArgs e)
        {
            if (!lsbKatilimcilar.SelectedIndex.Equals(-1))
            {
                lsbKatilimcilar.Items.RemoveAt(lsbKatilimcilar.SelectedIndex);
            }

        }
    }
}
