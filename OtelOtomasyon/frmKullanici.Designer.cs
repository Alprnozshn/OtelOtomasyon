namespace OtelOtomasyon
{
    partial class frmKullanici
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
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmKullaniciAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYetki = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKullanici
            // 
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKullaniciAd,
            this.clmSifre,
            this.clmYetki});
            this.gridKullanici.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridKullanici.Location = new System.Drawing.Point(108, 0);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(358, 320);
            this.gridKullanici.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmKullaniciAd
            // 
            this.clmKullaniciAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmKullaniciAd.DataPropertyName = "KullaniciAdi";
            this.clmKullaniciAd.HeaderText = "Kullanıcı Adı";
            this.clmKullaniciAd.Name = "clmKullaniciAd";
            // 
            // clmSifre
            // 
            this.clmSifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSifre.DataPropertyName = "KullaniciSifre";
            this.clmSifre.HeaderText = "Şifre";
            this.clmSifre.Name = "clmSifre";
            // 
            // clmYetki
            // 
            this.clmYetki.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmYetki.DataPropertyName = "YetkiID";
            this.clmYetki.HeaderText = "Yetkisi";
            this.clmYetki.Name = "clmYetki";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 320);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridKullanici);
            this.Name = "frmKullanici";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKullaniciAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSifre;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmYetki;
    }
}