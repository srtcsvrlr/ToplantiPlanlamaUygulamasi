namespace ToplantiPlanlamaUygulamasi
{
    partial class KullaniciPaneli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToplantiBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.ToplantiOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.ToplantiSec = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToplantiBilgileri,
            this.ToplantiOlustur,
            this.ToplantiSec});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(709, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToplantiBilgileri
            // 
            this.ToplantiBilgileri.Name = "ToplantiBilgileri";
            this.ToplantiBilgileri.Size = new System.Drawing.Size(132, 24);
            this.ToplantiBilgileri.Text = "Toplantı Bilgileri";
            // 
            // ToplantiOlustur
            // 
            this.ToplantiOlustur.Name = "ToplantiOlustur";
            this.ToplantiOlustur.Size = new System.Drawing.Size(128, 24);
            this.ToplantiOlustur.Text = "Toplantı Oluştur";
            this.ToplantiOlustur.Click += new System.EventHandler(this.toplantiOlusturToolStripMenuItem_Click);
            // 
            // ToplantiSec
            // 
            this.ToplantiSec.Name = "ToplantiSec";
            this.ToplantiSec.Size = new System.Drawing.Size(104, 24);
            this.ToplantiSec.Text = "Toplantı Seç";
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKullanici.Location = new System.Drawing.Point(0, 30);
            this.pnlKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(709, 623);
            this.pnlKullanici.TabIndex = 2;
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 653);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KullaniciPaneli";
            this.Text = "Toplantı Düzenleme Uygulaması || Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.KullaniciPaneli_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toplantiOlusturToolStripMenuItem;
        private ToolStripMenuItem toplantıSeçToolStripMenuItem;
        private ToolStripMenuItem ToplantiOlustur;
        private ToolStripMenuItem ToplantiSec;
        private Panel pnlKullanici;
        private ToolStripMenuItem ToplantiListesi;
        private ToolStripMenuItem ToplantiBilgileri;
    }
}