namespace ToplantiPlanlamaUygulamasi
{
    partial class ToplantiSec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUygunTarihleriSec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplantiSec = new System.Windows.Forms.Label();
            this.lstUygunTarihler = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.lstSecilenTarihler = new System.Windows.Forms.ListBox();
            this.lblUygunTarihler = new System.Windows.Forms.Label();
            this.lblSecilenTarihler = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUygunTarihleriSec
            // 
            this.btnUygunTarihleriSec.Location = new System.Drawing.Point(12, 303);
            this.btnUygunTarihleriSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUygunTarihleriSec.Name = "btnUygunTarihleriSec";
            this.btnUygunTarihleriSec.Size = new System.Drawing.Size(86, 31);
            this.btnUygunTarihleriSec.TabIndex = 1;
            this.btnUygunTarihleriSec.Text = "Gönder";
            this.btnUygunTarihleriSec.UseVisualStyleBackColor = true;
            this.btnUygunTarihleriSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblToplantiSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 57);
            this.panel1.TabIndex = 11;
            // 
            // lblToplantiSec
            // 
            this.lblToplantiSec.AutoSize = true;
            this.lblToplantiSec.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplantiSec.Location = new System.Drawing.Point(10, 8);
            this.lblToplantiSec.Name = "lblToplantiSec";
            this.lblToplantiSec.Size = new System.Drawing.Size(208, 37);
            this.lblToplantiSec.TabIndex = 9;
            this.lblToplantiSec.Text = "Toplantı Bilgileri";
            // 
            // lstUygunTarihler
            // 
            this.lstUygunTarihler.FormattingEnabled = true;
            this.lstUygunTarihler.ItemHeight = 20;
            this.lstUygunTarihler.Location = new System.Drawing.Point(12, 128);
            this.lstUygunTarihler.Name = "lstUygunTarihler";
            this.lstUygunTarihler.Size = new System.Drawing.Size(157, 144);
            this.lstUygunTarihler.TabIndex = 2;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(186, 128);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(67, 29);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // lstSecilenTarihler
            // 
            this.lstSecilenTarihler.FormattingEnabled = true;
            this.lstSecilenTarihler.ItemHeight = 20;
            this.lstSecilenTarihler.Location = new System.Drawing.Point(277, 128);
            this.lstSecilenTarihler.Name = "lstSecilenTarihler";
            this.lstSecilenTarihler.Size = new System.Drawing.Size(157, 144);
            this.lstSecilenTarihler.TabIndex = 4;
            // 
            // lblUygunTarihler
            // 
            this.lblUygunTarihler.AutoSize = true;
            this.lblUygunTarihler.Location = new System.Drawing.Point(8, 95);
            this.lblUygunTarihler.Name = "lblUygunTarihler";
            this.lblUygunTarihler.Size = new System.Drawing.Size(103, 20);
            this.lblUygunTarihler.TabIndex = 12;
            this.lblUygunTarihler.Text = "Uygun Tarihler";
            // 
            // lblSecilenTarihler
            // 
            this.lblSecilenTarihler.AutoSize = true;
            this.lblSecilenTarihler.Location = new System.Drawing.Point(277, 95);
            this.lblSecilenTarihler.Name = "lblSecilenTarihler";
            this.lblSecilenTarihler.Size = new System.Drawing.Size(108, 20);
            this.lblSecilenTarihler.TabIndex = 13;
            this.lblSecilenTarihler.Text = "Seçilen Tarihler";
            // 
            // ToplantiSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 394);
            this.Controls.Add(this.lblSecilenTarihler);
            this.Controls.Add(this.lblUygunTarihler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstSecilenTarihler);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstUygunTarihler);
            this.Controls.Add(this.btnUygunTarihleriSec);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToplantiSec";
            this.Text = "ToplantiSec";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnUygunTarihleriSec;
        private Panel panel1;
        private Label lblToplantiSec;
        private ListBox lstUygunTarihler;
        private Button btnSec;
        private ListBox lstSecilenTarihler;
        private Label lblUygunTarihler;
        private Label lblSecilenTarihler;
    }
}