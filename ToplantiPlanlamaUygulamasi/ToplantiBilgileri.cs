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
    public partial class ToplantiBilgileri : Form
    {
        public DateTime _currDate { get; set; }
        public Toplanti _toplanti { get; set; }
        public Kullanici _kullanici { get; set; }

        public bool toplantiTanimlanmis { get; set; } = false;

        List<KatilimciBilgileri> _katilimciBilgileriListesi = new List<KatilimciBilgileri>();

        public ToplantiBilgileri(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
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

            lsbKatilimcilar.Items.Clear();
            if (_toplanti.ToplantiTarihi.HasValue)
            {
                txtToplantiTarihi.Text = _toplanti.ToplantiTarihi?.ToString("yyyy-MM-dd");
                toplantiTanimlanmis = true;

                foreach (var item in _toplanti.NihaiKatilimciListesi)
                {
                    lsbKatilimcilar.Items.Add(item);
                }
                lsbKullanicininSectiğiTarihler.Visible = false;
                lsbTariheGoreKatilimcilar.Visible = false;
                btnToplantiKaydet.Visible = false;
                lblSecilenTarihteKatilabilecekler.Visible = false;
                lblSectiginizTarihler.Visible = false;
            }
            else
            {

                if (_kullanici.Name != "yonetici") {
                    btnToplantiKaydet.Visible = false;
                }

                foreach (var item in _toplanti.KatilimciListesi)
                {
                    lsbKatilimcilar.Items.Add(item);
                }
            }

            var katilimciBilgileriListesiJson = DosyaIslemleri.ReadData("KatilimciBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                _katilimciBilgileriListesi = JsonConvert.DeserializeObject<List<KatilimciBilgileri>>(katilimciBilgileriListesiJson);
            }


            if (_katilimciBilgileriListesi.Any(s => s.KatilimciAdi.Equals(_kullanici.Name)))
            {
                var loginOlanKullaniciSecilenTarihler = _katilimciBilgileriListesi.First(s => s.KatilimciAdi.Equals(_kullanici.Name));
                lsbKullanicininSectiğiTarihler.Items.Clear();
                foreach (var item in loginOlanKullaniciSecilenTarihler.SecilenTarihler)
                {
                    lsbKullanicininSectiğiTarihler.Items.Add(item.ToString("yyyy-MM-dd"));
                }
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
                    if (_toplanti.ToplantiTarihi.Equals(currDate))
                    {
                        ctrl.BackColor = Color.Blue;
                    }
                    ctrl.Controls.Add(dynamiclabel);

                    // uygun toplantı tarihlerindeki katılımcıları görmek için buton ekle
                    if (!toplantiTanimlanmis && _toplanti.UygunToplantiTarihleri.Any(s => s.Equals(currDate)))
                    {
                        System.Windows.Forms.Button dynamicButton = new System.Windows.Forms.Button();
                        dynamicButton.Location = new Point(0, 40);
                        dynamicButton.Name = "btnKatilimcilar_" + currDate.ToString("yyyy-MM-dd");
                        dynamicButton.Text = "Katılımcılar";
                        dynamicButton.Size = new System.Drawing.Size(100, 26);
                        dynamicButton.Font = new Font("Arial", 9, FontStyle.Regular);
                        dynamicButton.Click += new EventHandler(katilimciGosterButton_Click);
                        ctrl.Controls.Add(dynamicButton);
                        if (!_kullanici.Name.Equals("yonetici"))
                        {
                            var loginOlanKullaniciSecilenTarihler = _katilimciBilgileriListesi.FirstOrDefault(s => s.KatilimciAdi.Equals(_kullanici.Name));
                            if (loginOlanKullaniciSecilenTarihler != null)
                            {
                                if (loginOlanKullaniciSecilenTarihler.SecilenTarihler.Any(s => s.Equals(currDate)))
                                {
                                    // kullanici ilgili tarihi seçmemişse göster
                                    System.Windows.Forms.Button dynamicButton2 = new System.Windows.Forms.Button();
                                    dynamicButton2.Location = new Point(0, 66);
                                    dynamicButton2.Name = "btnKaldır_" + currDate.ToString("yyyy-MM-dd");
                                    dynamicButton2.Text = "Kaldır";
                                    dynamicButton2.Size = new System.Drawing.Size(100, 26);
                                    dynamicButton2.Font = new Font("Arial", 9, FontStyle.Regular);

                                    dynamicButton2.Click += new EventHandler(tarihiKaldir_Click);
                                    ctrl.Controls.Add(dynamicButton2);
                                }
                                else
                                {
                                    // kullanici ilgili tarihi seçmemişse göster
                                    Button dynamicButton2 = new Button();
                                    dynamicButton2.Location = new Point(0, 66);
                                    dynamicButton2.Name = "btnSec_" + currDate.ToString("yyyy-MM-dd");
                                    dynamicButton2.Text = "Seç";
                                    dynamicButton2.Size = new System.Drawing.Size(100, 26);
                                    dynamicButton2.Font = new Font("Arial", 9, FontStyle.Regular);
                                    dynamicButton2.Click += new EventHandler(tarihiEkle_Click);
                                    ctrl.Controls.Add(dynamicButton2);
                                }

                            }
                            else
                            {
                                // kullanici ilgili tarihi seçmemişse göster
                                Button dynamicButton2 = new Button();
                                dynamicButton2.Location = new Point(0, 66);
                                dynamicButton2.Name = "btnSec_" + currDate.ToString("yyyy-MM-dd");
                                dynamicButton2.Text = "Seç";
                                dynamicButton2.Size = new System.Drawing.Size(100, 26);
                                dynamicButton2.Font = new Font("Arial", 9, FontStyle.Regular);
                                dynamicButton2.Click += new EventHandler(tarihiEkle_Click);
                                ctrl.Controls.Add(dynamicButton2);


                            }
                        }
                        else
                        {
                            // kullanici ilgili tarihi seçmemişse göster
                            Button dynamicButton3 = new Button();
                            dynamicButton3.Location = new Point(0, 66);
                            dynamicButton3.Name = "btnSec_" + currDate.ToString("yyyy-MM-dd");
                            dynamicButton3.Text = "Seç";
                            dynamicButton3.Size = new System.Drawing.Size(100, 26);
                            dynamicButton3.Font = new Font("Arial", 9, FontStyle.Regular);
                            dynamicButton3.Click += new EventHandler(toplantiTarihiBelirle_Click);
                            ctrl.Controls.Add(dynamicButton3);
                        }

                    }
                }
                currDate = currDate.AddDays(1);

            }
        }

        private void toplantiTarihiBelirle_Click(object? sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.Name;
            var strTarih = strName.Split("_")[1];
            DateTime selectedDate = Convert.ToDateTime(strTarih);
            MessageBox.Show("Seçtiğiniz Toplantı Tarihi: " + strTarih + " !!");
            txtToplantiTarihi.Text = strTarih;

        }

        private void tarihiEkle_Click(object? sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.Name;
            var strTarih = strName.Split("_")[1];
            DateTime selectedDate = Convert.ToDateTime(strTarih);



            List<KatilimciBilgileri> katilimciBilgileriListesi = new List<KatilimciBilgileri>();

            var katilimciBilgileriListesiJson = DosyaIslemleri.ReadData("KatilimciBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                katilimciBilgileriListesi = JsonConvert.DeserializeObject<List<KatilimciBilgileri>>(katilimciBilgileriListesiJson);
            }

            var katilimciBilgileri = katilimciBilgileriListesi.FirstOrDefault(s => s.KatilimciAdi.Equals(_kullanici.Name));

            if (katilimciBilgileri != null)
            {
                katilimciBilgileri.SecilenTarihler.Add(selectedDate);
                katilimciBilgileriListesi.
                    Remove(katilimciBilgileriListesi.First(s => s.KatilimciAdi == _kullanici.Name));
                katilimciBilgileriListesi.Add(katilimciBilgileri);
            }
            else
            {
                katilimciBilgileri = new KatilimciBilgileri()
                {
                    KatilimciAdi = _kullanici.Name,
                    SecilenTarihler = new List<DateTime> { selectedDate }
                };

                katilimciBilgileriListesi.Add(katilimciBilgileri);
            }

            var jsonData2 = JsonConvert.SerializeObject(katilimciBilgileriListesi);
            DosyaIslemleri.WriteData("KatilimciBilgileri.txt", jsonData2);
            _katilimciBilgileriListesi = katilimciBilgileriListesi;
            if (!ToplantiBilgileriniGetir())
                return;
            KutulariDoldur(_currDate);

        }

        private void tarihiKaldir_Click(object? sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.Name;
            var strTarih = strName.Split("_")[1];
            DateTime selectedDate = Convert.ToDateTime(strTarih);
            List<KatilimciBilgileri> katilimciBilgileriListesi = new List<KatilimciBilgileri>();

            var katilimciBilgileriListesiJson = DosyaIslemleri.ReadData("KatilimciBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                katilimciBilgileriListesi = JsonConvert.DeserializeObject<List<KatilimciBilgileri>>(katilimciBilgileriListesiJson);
            }

            var katilimciBilgileri = katilimciBilgileriListesi.First(s => s.KatilimciAdi.Equals(_kullanici.Name));

            if (katilimciBilgileri != null)
            {
                katilimciBilgileri.SecilenTarihler.Remove(selectedDate);
                katilimciBilgileriListesi.
                    Remove(katilimciBilgileriListesi.First(s => s.KatilimciAdi == _kullanici.Name));
                katilimciBilgileriListesi.Add(katilimciBilgileri);
            }

            var jsonData2 = JsonConvert.SerializeObject(katilimciBilgileriListesi);
            DosyaIslemleri.WriteData("KatilimciBilgileri.txt", jsonData2);
            _katilimciBilgileriListesi = katilimciBilgileriListesi;
            if (!ToplantiBilgileriniGetir())
                return;
            KutulariDoldur(_currDate);
        }

        private void katilimciGosterButton_Click(object sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.Name;
            var strTarih = strName.Split("_")[1];
            DateTime selectedDate = Convert.ToDateTime(strTarih);

            IlgiliTarihtekiKatilimcilariGetir(selectedDate);
        }

        private void IlgiliTarihtekiKatilimcilariGetir(DateTime selectedDate)
        {
            lsbTariheGoreKatilimcilar.Items.Clear();
            foreach (var item in _katilimciBilgileriListesi)
            {
                if (item.SecilenTarihler.Any(s => s.Equals(selectedDate)))
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

        private void btnToplantiKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToplantiTarihi.Text.Trim()))
            {
                MessageBox.Show("Uygun Tarihler içerisinden Toplantı Tarihini seçiniz!");
                return;
            }
            if (_toplanti.NihaiKatilimciListesi == null)
            {
                var confirmResult = MessageBox.Show("Seçtiğiniz toplantı tarihinde uygun olmayan katılımcılar var! Devam etmek istiyor musunuz?",
                                    "Uyarı!!",
                                    MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                if (_toplanti.NihaiKatilimciListesi.Count != _toplanti.KatilimciListesi.Count)
                {
                    var confirmResult = MessageBox.Show("Seçtiğiniz toplantı tarihinde uygun olmayan katılımcılar var! Devam etmek istiyor musunuz?",
                                         "Uyarı!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }



            _toplanti.ToplantiTarihi = Convert.ToDateTime(txtToplantiTarihi.Text);

            List<KatilimciBilgileri> katilimciBilgileriListesi = new List<KatilimciBilgileri>();

            var katilimciBilgileriListesiJson = DosyaIslemleri.ReadData("KatilimciBilgileri.txt");
            if (katilimciBilgileriListesiJson.Trim() != string.Empty)
            {
                katilimciBilgileriListesi = JsonConvert.DeserializeObject<List<KatilimciBilgileri>>(katilimciBilgileriListesiJson);
            }
            _toplanti.NihaiKatilimciListesi = new List<string>();
            foreach (var katilimci in katilimciBilgileriListesi)
            {

                if (katilimci.SecilenTarihler.Any(s => s.Equals(_toplanti.ToplantiTarihi)))
                {

                    _toplanti.NihaiKatilimciListesi.Add(katilimci.KatilimciAdi);
                }
            }

            var jsonData = JsonConvert.SerializeObject(_toplanti);
            DosyaIslemleri.WriteData("ToplantiBilgileri.txt", jsonData);

            MessageBox.Show("Toplantı Tarihi başarıyla kaydedildi ve toplantı bilgileri kullanıcılara gönderildi!");
            this.Hide();
        }


    }
}
