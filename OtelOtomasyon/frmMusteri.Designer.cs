namespace OtelOtomasyon
{
    partial class frmMusteri
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
            this.btnMusEkle = new System.Windows.Forms.Button();
            this.cmEBosOda = new System.Windows.Forms.ComboBox();
            this.lblTcKNo = new System.Windows.Forms.Label();
            this.lblEAdi = new System.Windows.Forms.Label();
            this.lblESoyadi = new System.Windows.Forms.Label();
            this.lblEGirTar = new System.Windows.Forms.Label();
            this.lblECikTar = new System.Windows.Forms.Label();
            this.lblEBosOda = new System.Windows.Forms.Label();
            this.dtpEGirTar = new System.Windows.Forms.DateTimePicker();
            this.dtpECikTar = new System.Windows.Forms.DateTimePicker();
            this.txtETcKNo = new CustomControlsLib.MyTextBox();
            this.txtEAdi = new CustomControlsLib.MyTextBox();
            this.txtESoyadi = new CustomControlsLib.MyTextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.Location = new System.Drawing.Point(84, 169);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusEkle.TabIndex = 0;
            this.btnMusEkle.Text = "Ekle";
            this.btnMusEkle.UseVisualStyleBackColor = true;
            this.btnMusEkle.Click += new System.EventHandler(this.btnMusEkle_Click);
            // 
            // cmEBosOda
            // 
            this.cmEBosOda.FormattingEnabled = true;
            this.cmEBosOda.Location = new System.Drawing.Point(84, 142);
            this.cmEBosOda.Name = "cmEBosOda";
            this.cmEBosOda.Size = new System.Drawing.Size(176, 21);
            this.cmEBosOda.TabIndex = 8;
            // 
            // lblTcKNo
            // 
            this.lblTcKNo.AutoSize = true;
            this.lblTcKNo.Location = new System.Drawing.Point(7, 15);
            this.lblTcKNo.Name = "lblTcKNo";
            this.lblTcKNo.Size = new System.Drawing.Size(71, 13);
            this.lblTcKNo.TabIndex = 9;
            this.lblTcKNo.Text = "TC Kimlik No:";
            // 
            // lblEAdi
            // 
            this.lblEAdi.AutoSize = true;
            this.lblEAdi.Location = new System.Drawing.Point(53, 41);
            this.lblEAdi.Name = "lblEAdi";
            this.lblEAdi.Size = new System.Drawing.Size(25, 13);
            this.lblEAdi.TabIndex = 10;
            this.lblEAdi.Text = "Adı:";
            // 
            // lblESoyadi
            // 
            this.lblESoyadi.AutoSize = true;
            this.lblESoyadi.Location = new System.Drawing.Point(36, 67);
            this.lblESoyadi.Name = "lblESoyadi";
            this.lblESoyadi.Size = new System.Drawing.Size(42, 13);
            this.lblESoyadi.TabIndex = 11;
            this.lblESoyadi.Text = "Soyadı:";
            // 
            // lblEGirTar
            // 
            this.lblEGirTar.AutoSize = true;
            this.lblEGirTar.Location = new System.Drawing.Point(19, 93);
            this.lblEGirTar.Name = "lblEGirTar";
            this.lblEGirTar.Size = new System.Drawing.Size(59, 13);
            this.lblEGirTar.TabIndex = 12;
            this.lblEGirTar.Text = "Giriş Tarihi:";
            // 
            // lblECikTar
            // 
            this.lblECikTar.AutoSize = true;
            this.lblECikTar.Location = new System.Drawing.Point(17, 119);
            this.lblECikTar.Name = "lblECikTar";
            this.lblECikTar.Size = new System.Drawing.Size(61, 13);
            this.lblECikTar.TabIndex = 13;
            this.lblECikTar.Text = "Çıkış Tarihi:";
            // 
            // lblEBosOda
            // 
            this.lblEBosOda.AutoSize = true;
            this.lblEBosOda.Location = new System.Drawing.Point(16, 145);
            this.lblEBosOda.Name = "lblEBosOda";
            this.lblEBosOda.Size = new System.Drawing.Size(62, 13);
            this.lblEBosOda.TabIndex = 14;
            this.lblEBosOda.Text = "Boş Odalar:";
            // 
            // dtpEGirTar
            // 
            this.dtpEGirTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEGirTar.Location = new System.Drawing.Point(84, 90);
            this.dtpEGirTar.Name = "dtpEGirTar";
            this.dtpEGirTar.Size = new System.Drawing.Size(176, 20);
            this.dtpEGirTar.TabIndex = 15;
            // 
            // dtpECikTar
            // 
            this.dtpECikTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpECikTar.Location = new System.Drawing.Point(84, 116);
            this.dtpECikTar.Name = "dtpECikTar";
            this.dtpECikTar.Size = new System.Drawing.Size(176, 20);
            this.dtpECikTar.TabIndex = 16;
            // 
            // txtETcKNo
            // 
            this.txtETcKNo.CalismaModu = CustomControlsLib.WorkMode.Sayi;
            this.txtETcKNo.Location = new System.Drawing.Point(0, 3);
            this.txtETcKNo.Name = "txtETcKNo";
            this.txtETcKNo.Size = new System.Drawing.Size(176, 20);
            this.txtETcKNo.TabIndex = 17;
            // 
            // txtEAdi
            // 
            this.txtEAdi.CalismaModu = CustomControlsLib.WorkMode.Harf;
            this.txtEAdi.Location = new System.Drawing.Point(0, 29);
            this.txtEAdi.Name = "txtEAdi";
            this.txtEAdi.Size = new System.Drawing.Size(176, 20);
            this.txtEAdi.TabIndex = 18;
            // 
            // txtESoyadi
            // 
            this.txtESoyadi.CalismaModu = CustomControlsLib.WorkMode.Harf;
            this.txtESoyadi.Location = new System.Drawing.Point(0, 55);
            this.txtESoyadi.Name = "txtESoyadi";
            this.txtESoyadi.Size = new System.Drawing.Size(176, 20);
            this.txtESoyadi.TabIndex = 19;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(185, 169);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 20;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(84, 198);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Visible = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(185, 198);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 22;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtETcKNo);
            this.pnlText.Controls.Add(this.txtEAdi);
            this.pnlText.Controls.Add(this.txtESoyadi);
            this.pnlText.Location = new System.Drawing.Point(84, 9);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(185, 81);
            this.pnlText.TabIndex = 23;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 271);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.dtpECikTar);
            this.Controls.Add(this.dtpEGirTar);
            this.Controls.Add(this.lblEBosOda);
            this.Controls.Add(this.lblECikTar);
            this.Controls.Add(this.lblEGirTar);
            this.Controls.Add(this.lblESoyadi);
            this.Controls.Add(this.lblEAdi);
            this.Controls.Add(this.lblTcKNo);
            this.Controls.Add(this.cmEBosOda);
            this.Controls.Add(this.btnMusEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTcKNo;
        private System.Windows.Forms.Label lblEAdi;
        private System.Windows.Forms.Label lblESoyadi;
        private System.Windows.Forms.Label lblEGirTar;
        private System.Windows.Forms.Label lblECikTar;
        private System.Windows.Forms.Label lblEBosOda;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnMusEkle;
        public System.Windows.Forms.ComboBox cmEBosOda;
        public System.Windows.Forms.DateTimePicker dtpEGirTar;
        public System.Windows.Forms.DateTimePicker dtpECikTar;
        public CustomControlsLib.MyTextBox txtETcKNo;
        public CustomControlsLib.MyTextBox txtEAdi;
        public CustomControlsLib.MyTextBox txtESoyadi;
        public System.Windows.Forms.Button BtnSil;
        public System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel pnlText;
    }
}