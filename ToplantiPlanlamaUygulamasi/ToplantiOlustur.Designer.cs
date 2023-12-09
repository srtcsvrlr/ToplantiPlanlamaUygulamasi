namespace ToplantiPlanlamaUygulamasi
{
    partial class ToplantiOlustur
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
            this.components = new System.ComponentModel.Container();
            this.btnToplantiOlustur = new System.Windows.Forms.Button();
            this.clndrToplantiTarihleri = new System.Windows.Forms.MonthCalendar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lsbTarihler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTarihSil = new System.Windows.Forms.Button();
            this.rctxtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToplantiOlustur
            // 
            this.btnToplantiOlustur.Location = new System.Drawing.Point(95, 424);
            this.btnToplantiOlustur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToplantiOlustur.Name = "btnToplantiOlustur";
            this.btnToplantiOlustur.Size = new System.Drawing.Size(102, 31);
            this.btnToplantiOlustur.TabIndex = 0;
            this.btnToplantiOlustur.Text = "Kaydet";
            this.btnToplantiOlustur.UseVisualStyleBackColor = true;
            this.btnToplantiOlustur.Click += new System.EventHandler(this.btnToplantiOlustur_Click);
            // 
            // clndrToplantiTarihleri
            // 
            this.clndrToplantiTarihleri.Location = new System.Drawing.Point(95, 201);
            this.clndrToplantiTarihleri.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.clndrToplantiTarihleri.Name = "clndrToplantiTarihleri";
            this.clndrToplantiTarihleri.TabIndex = 1;
            this.clndrToplantiTarihleri.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clndrToplantiTarihleri_DateSelected);
            this.clndrToplantiTarihleri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "test";
            // 
            // lsbTarihler
            // 
            this.lsbTarihler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbTarihler.FormattingEnabled = true;
            this.lsbTarihler.ItemHeight = 20;
            this.lsbTarihler.Location = new System.Drawing.Point(379, 201);
            this.lsbTarihler.Name = "lsbTarihler";
            this.lsbTarihler.Size = new System.Drawing.Size(120, 202);
            this.lsbTarihler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarihler :";
            // 
            // btnTarihSil
            // 
            this.btnTarihSil.Location = new System.Drawing.Point(505, 207);
            this.btnTarihSil.Name = "btnTarihSil";
            this.btnTarihSil.Size = new System.Drawing.Size(39, 29);
            this.btnTarihSil.TabIndex = 4;
            this.btnTarihSil.Text = "Sil";
            this.btnTarihSil.UseVisualStyleBackColor = true;
            this.btnTarihSil.Click += new System.EventHandler(this.btnTarihSil_Click);
            // 
            // rctxtAciklama
            // 
            this.rctxtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rctxtAciklama.Location = new System.Drawing.Point(95, 131);
            this.rctxtAciklama.Name = "rctxtAciklama";
            this.rctxtAciklama.Size = new System.Drawing.Size(404, 55);
            this.rctxtAciklama.TabIndex = 5;
            this.rctxtAciklama.Text = "";
            // 
            // txtBaslik
            // 
            this.txtBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaslik.Location = new System.Drawing.Point(95, 87);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(404, 27);
            this.txtBaslik.TabIndex = 6;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(15, 89);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(54, 20);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Başlık :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(15, 137);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 20);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toplantı Oluştur";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 57);
            this.panel1.TabIndex = 10;
            // 
            // ToplantiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.rctxtAciklama);
            this.Controls.Add(this.btnTarihSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbTarihler);
            this.Controls.Add(this.clndrToplantiTarihleri);
            this.Controls.Add(this.btnToplantiOlustur);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToplantiOlustur";
            this.Text = "Toplantı Düzenleme Uygulaması || Toplantı Oluştur";
            this.Load += new System.EventHandler(this.ToplantiOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnToplantiOlustur;
        public MonthCalendar clndrToplantiTarihleri;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
        private ListBox lsbTarihler;
        private Label label1;
        private Button btnTarihSil;
        private RichTextBox rctxtAciklama;
        private TextBox txtBaslik;
        private Label lblBaslik;
        private Label lblAciklama;
        private Label label2;
        private Panel panel1;
    }
}