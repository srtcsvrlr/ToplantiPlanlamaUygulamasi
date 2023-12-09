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
        public ToplantiBilgileri()
        {
            InitializeComponent();
        }

        private void ToplantiBilgileri_Load(object sender, EventArgs e)
        {
            TakvimKutulariniOlustur();
            //KutulariDoldur();
        }

        public void TakvimKutulariniOlustur()
        {
            var ayinIlkGunu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var ayinIlkGunuIndeksi = (int)ayinIlkGunu.DayOfWeek;

            var startDate = ayinIlkGunu.AddDays(-(ayinIlkGunuIndeksi - 1));


            var currDate = startDate;

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
                        80 + a * 100 + (a == 0 ? 0 : 7 * a), 160 + 100 * i + (i == 0 ? 0 : 7 * i));
                    p.Visible = true; p.BorderStyle = BorderStyle.FixedSingle;

                    Controls.Add(p);
                    KutulariDoldur(p, currDate, c++);

                    currDate = currDate.AddDays(1);
                }
            }

            this.ParentForm.Height = 900;
            this.ParentForm.Width = 900;
        }


        public void KutulariDoldur(Control ctrl, DateTime currDate, int i)
        {




            Label dynamiclabel = new Label();
            dynamiclabel.Location = new Point(10, 10);
            dynamiclabel.Name = "lbl_ques" + i;
            dynamiclabel.Text = currDate.ToString("dd");
            dynamiclabel.Size = new System.Drawing.Size(900, 26);
            dynamiclabel.Font = new Font("Arial", 9, FontStyle.Regular);
            ctrl.Controls.Add(dynamiclabel);
            Button dynamicButton = new Button();
            dynamicButton.Location = new Point(10, 50);
            dynamicButton.Name = "btnSec_" + currDate.ToString("yyyy-MM-dd");
            dynamicButton.Text = "Seç";
            dynamicButton.Size = new System.Drawing.Size(50, 26);
            dynamicButton.Font = new Font("Arial", 9, FontStyle.Regular);
            ctrl.Controls.Add(dynamicButton);
        }





    }
}
