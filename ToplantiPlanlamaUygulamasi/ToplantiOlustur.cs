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
            DateTime myVacation1 = new DateTime(2023, 12, 13);
            DateTime myVacation2 = new DateTime(2023, 12, 16);      
            monthCalendar1.AddBoldedDate(myVacation1);
            monthCalendar1.AddBoldedDate(myVacation2);

            this.monthCalendar1.SetDate(
              new System.DateTime(2023, 12, 13, 0, 0, 0, 0)); 
            
            this.monthCalendar1.SetDate(
              new System.DateTime(2023, 12, 15, 0, 0, 0, 0));
        }

        private void monthCalendar1_MouseMove(object sender, MouseEventArgs e)
        {
                MonthCalendar.HitTestInfo hit = monthCalendar1.HitTest(e.Location);
                if (hit.Time == new DateTime(2023, 12, 07))
                {
                    toolTip1.SetToolTip(monthCalendar1,"toplanti-1");
                }
            
        }
    }
}
