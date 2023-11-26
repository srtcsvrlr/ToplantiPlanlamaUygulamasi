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
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(269, 227);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(216, 29);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(269, 80);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(306, 27);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(159, 87);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(99, 20);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSifre.Location = new System.Drawing.Point(159, 144);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(269, 137);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(306, 27);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmToplantiUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1043, 551);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmToplantiUygulamasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantı Düzenleme Uygulaması";
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
    }
}