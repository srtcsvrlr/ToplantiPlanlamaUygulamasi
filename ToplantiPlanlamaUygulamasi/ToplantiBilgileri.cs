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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToplantiPlanlamaUygulamasi
{
    public partial class ToplantiBilgileri : Form
    {
        public DateTime _currDate { get; set; }
        public Toplanti _toplanti { get; set; }

        List<KatilimciBilgileri> _katilimciBilgileriListesi = new List<KatilimciBilgileri>();

        public ToplantiBilgileri()
        {
            InitializeComponent();
        }

        private void ToplantiBilgileri_Load(object sender, EventArgs e)
        {
            _currDate = DateTime.Now;
            TakvimKutulariniOlustur();
            if (!ToplantiBilgileriniGetir())
                return;
            KutulariDoldur(_currDate);
        }

        // Tüm kullanıcıların uygun olduğu tarihleri panelde gösterir
        private bool ToplantiBilgileriniGetir()
        {
            string jsonToplantiBilgileri = ReadToplantiBilgileri();
            _toplanti = JsonConvert.DeserializeObject<Toplanti>(jsonToplantiBilgileri);
            if (_toplanti == null)
            {
                MessageBox.Show("Toplanti Bilgileri Alınamadı.");
                return false;
            }

            txtBaslik.Text = _toplanti.Baslik;
            rctxtAciklama.Text = _toplanti.Aciklama;
            txtToplantiKodu.Text = _toplanti.ToplantiKodu;
            foreach (var item in _toplanti.KatilimciListesi)
            {
                lsbKatilimcilar.Items.Add(item);
            }


          
            var katilimciBilgileriListesiJson = DosyaIslemleri.ReadData("KatilimciBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                _katilimciBilgileriListesi = JsonConvert.DeserializeObject<List<KatilimciBilgileri>>(katilimciBilgileriListesiJson);
            }


            return true;
        }

        public string ReadToplantiBilgileri()
        {
            return DosyaIslemleri.ReadData("ToplantiBilgileri.txt");
        }

        public void TakvimKutulariniOlustur()
        {
            var c = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    c++;
                    Panel p = new Panel();
                    p.Width = 100; p.Height = 100;
                    p.Name = "pnlTakvimGunu" + c;
                    p.Location = new Point(
                         90 + a * 100 + (a == 0 ? 0 : 7 * a), 250 + 100 * i + (i == 0 ? 0 : 7 * i));
                    p.Visible = true; p.BorderStyle = BorderStyle.FixedSingle;

                    Controls.Add(p);

                }
            }

        }

        public void KutulariDoldur(DateTime date)
        {

            lblAyYilBilgisi.Text = date.ToString("MMMM") + " " + date.ToString("yyyy");
            var ayinIlkGunu = new DateTime(date.Year, date.Month, 1);
            var ayinIlkGunuIndeksi = (int)ayinIlkGunu.DayOfWeek;

            var startDate = ayinIlkGunu.AddDays(-(ayinIlkGunuIndeksi - 1));
            var currDate = startDate;

            for (int i = 0; i < 42; i++)
            {
                var ctrl = Controls["pnlTakvimGunu" + (i + 1)];
                if (ctrl != null)
                {
                    ctrl.Controls.Clear();
                    Label dynamiclabel = new Label();
                    dynamiclabel.Location = new Point(10, 10);
                    dynamiclabel.Name = "lbl_ques" + i;
                    dynamiclabel.Text = currDate.ToString("dd");
                    dynamiclabel.Size = new System.Drawing.Size(900, 26);
                    dynamiclabel.Font = new Font("Arial", 9, FontStyle.Regular);
                    ctrl.Controls.Add(dynamiclabel);
                    // uygun toplantı tarihlerindeki katılımcıları görmek için buton ekle
                    if (_toplanti.UygunToplantiTarihleri.Any(s => s.Equals(currDate)))
                    {
                        Button dynamicButton = new Button();
                        dynamicButton.Location = new Point(10, 50);
                        dynamicButton.Name = "btnKatilimcilar_" + currDate.ToString("yyyy-MM-dd");
                        dynamicButton.Text = "Katılımcılar";
                        dynamicButton.Size = new System.Drawing.Size(50, 26);
                        dynamicButton.Font = new Font("Arial", 9, FontStyle.Regular);

                        dynamicButton.Click += new EventHandler(dynamicButton_Click);
                        ctrl.Controls.Add(dynamicButton);
                    }
                }
                currDate = currDate.AddDays(1);

            }
        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.Name;
            var strTarih = strName.Split("_")[1];
            DateTime selectedDate = Convert.ToDateTime(strTarih);

            IlgiliTarihtekiKatilimcilariGetir(selectedDate);
        }

        private void IlgiliTarihtekiKatilimcilariGetir(DateTime selectedDate)
        {
            MessageBox.Show(selectedDate.ToString("yyyy-MM-dd"));
            foreach (var item in _katilimciBilgileriListesi)
            {
                if (item.SecilenTarihler.Any(s=>s.Equals(selectedDate)))
                {
                    lsbTariheGoreKatilimcilar.Items.Add(item.KatilimciAdi);
                }
            }
            return;
        }

        private void btnOncekiAy_Click(object sender, EventArgs e)
        {
            _currDate = _currDate.AddMonths(-1);
            KutulariDoldur(_currDate);
        }

        private void btnSonrakiAy_Click(object sender, EventArgs e)
        {
            _currDate = _currDate.AddMonths(1);
            KutulariDoldur(_currDate);
        }
    }
}
