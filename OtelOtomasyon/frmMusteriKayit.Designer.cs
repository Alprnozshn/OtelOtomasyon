namespace OtelOtomasyon
{
    partial class frmMusteriKayit
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
            this.txtETcKNo = new System.Windows.Forms.TextBox();
            this.txtEAdi = new System.Windows.Forms.TextBox();
            this.txtESoyadi = new System.Windows.Forms.TextBox();
            this.cmEBosOda = new System.Windows.Forms.ComboBox();
            this.lblTcKNo = new System.Windows.Forms.Label();
            this.lblEAdi = new System.Windows.Forms.Label();
            this.lblESoyadi = new System.Windows.Forms.Label();
            this.lblEGirTar = new System.Windows.Forms.Label();
            this.lblECikTar = new System.Windows.Forms.Label();
            this.lblEBosOda = new System.Windows.Forms.Label();
            this.dtpEGirTar = new System.Windows.Forms.DateTimePicker();
            this.dtpECikTar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.Location = new System.Drawing.Point(102, 175);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusEkle.TabIndex = 0;
            this.btnMusEkle.Text = "Ekle";
            this.btnMusEkle.UseVisualStyleBackColor = true;
            this.btnMusEkle.Click += new System.EventHandler(this.btnMusEkle_Click);
            // 
            // txtETcKNo
            // 
            this.txtETcKNo.Location = new System.Drawing.Point(84, 12);
            this.txtETcKNo.Name = "txtETcKNo";
            this.txtETcKNo.Size = new System.Drawing.Size(176, 20);
            this.txtETcKNo.TabIndex = 1;
            // 
            // txtEAdi
            // 
            this.txtEAdi.Location = new System.Drawing.Point(84, 38);
            this.txtEAdi.Name = "txtEAdi";
            this.txtEAdi.Size = new System.Drawing.Size(176, 20);
            this.txtEAdi.TabIndex = 2;
            // 
            // txtESoyadi
            // 
            this.txtESoyadi.Location = new System.Drawing.Point(84, 64);
            this.txtESoyadi.Name = "txtESoyadi";
            this.txtESoyadi.Size = new System.Drawing.Size(176, 20);
            this.txtESoyadi.TabIndex = 3;
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
            // frmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 210);
            this.Controls.Add(this.dtpECikTar);
            this.Controls.Add(this.dtpEGirTar);
            this.Controls.Add(this.lblEBosOda);
            this.Controls.Add(this.lblECikTar);
            this.Controls.Add(this.lblEGirTar);
            this.Controls.Add(this.lblESoyadi);
            this.Controls.Add(this.lblEAdi);
            this.Controls.Add(this.lblTcKNo);
            this.Controls.Add(this.cmEBosOda);
            this.Controls.Add(this.txtESoyadi);
            this.Controls.Add(this.txtEAdi);
            this.Controls.Add(this.txtETcKNo);
            this.Controls.Add(this.btnMusEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusEkle;
        private System.Windows.Forms.TextBox txtETcKNo;
        private System.Windows.Forms.TextBox txtEAdi;
        private System.Windows.Forms.TextBox txtESoyadi;
        private System.Windows.Forms.ComboBox cmEBosOda;
        private System.Windows.Forms.Label lblTcKNo;
        private System.Windows.Forms.Label lblEAdi;
        private System.Windows.Forms.Label lblESoyadi;
        private System.Windows.Forms.Label lblEGirTar;
        private System.Windows.Forms.Label lblECikTar;
        private System.Windows.Forms.Label lblEBosOda;
        private System.Windows.Forms.DateTimePicker dtpEGirTar;
        private System.Windows.Forms.DateTimePicker dtpECikTar;
    }
}