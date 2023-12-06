namespace ToplantiPlanlamaUygulamasi
{
    partial class frmToplantiUygulamasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(114, 123);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(108, 27);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(114, 43);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(180, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(18, 48);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 15);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSifre.Location = new System.Drawing.Point(18, 91);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(36, 15);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(114, 86);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 23);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGiris
            // 
            this.lblGiris.BackColor = System.Drawing.Color.Transparent;
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(110, 166);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(268, 15);
            this.lblGiris.TabIndex = 6;
            // 
            // frmToplantiUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(390, 215);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmToplantiUygulamasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantı Düzenleme Uygulaması || Giris Paneli";
            this.Load += new System.EventHandler(this.frmToplantiUygulamasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGiris;
        private TextBox txtKullaniciAdi;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Label lblGiris;
    }
}