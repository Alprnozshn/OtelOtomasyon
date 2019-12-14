namespace OtelOtomasyon
{
    partial class frmResepsiyon
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
            this.dgwResepsiyon = new System.Windows.Forms.DataGridView();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriGirTar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriCikTar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResepsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwResepsiyon
            // 
            this.dgwResepsiyon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwResepsiyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResepsiyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusteriID,
            this.MusteriTC,
            this.MusteriAd,
            this.MusteriSoyad,
            this.MusteriGirTar,
            this.MusteriCikTar,
            this.clmOdaNo});
            this.dgwResepsiyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwResepsiyon.Location = new System.Drawing.Point(0, 40);
            this.dgwResepsiyon.Name = "dgwResepsiyon";
            this.dgwResepsiyon.Size = new System.Drawing.Size(719, 410);
            this.dgwResepsiyon.TabIndex = 1;
            this.dgwResepsiyon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResepsiyon_CellEndEdit);
            // 
            // MusteriID
            // 
            this.MusteriID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriID.DataPropertyName = "MusteriKayitID";
            this.MusteriID.HeaderText = "ID";
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.ReadOnly = true;
            // 
            // MusteriTC
            // 
            this.MusteriTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriTC.DataPropertyName = "MusteriTcKNo";
            this.MusteriTC.HeaderText = "TC Kimlik No";
            this.MusteriTC.Name = "MusteriTC";
            // 
            // MusteriAd
            // 
            this.MusteriAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriAd.DataPropertyName = "MusteriAd";
            this.MusteriAd.HeaderText = "Adı";
            this.MusteriAd.Name = "MusteriAd";
            // 
            // MusteriSoyad
            // 
            this.MusteriSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriSoyad.DataPropertyName = "MusteriSoyad";
            this.MusteriSoyad.HeaderText = "Soyadı";
            this.MusteriSoyad.Name = "MusteriSoyad";
            // 
            // MusteriGirTar
            // 
            this.MusteriGirTar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriGirTar.DataPropertyName = "MusteriGirisTarih";
            this.MusteriGirTar.HeaderText = "Giriş Tarihi";
            this.MusteriGirTar.Name = "MusteriGirTar";
            // 
            // MusteriCikTar
            // 
            this.MusteriCikTar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriCikTar.DataPropertyName = "MusteriCikisTarih";
            this.MusteriCikTar.HeaderText = "Çıkış Tarihi";
            this.MusteriCikTar.Name = "MusteriCikTar";
            // 
            // clmOdaNo
            // 
            this.clmOdaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmOdaNo.DataPropertyName = "MusteriOdaNo";
            this.clmOdaNo.HeaderText = "Oda No";
            this.clmOdaNo.Name = "clmOdaNo";
            this.clmOdaNo.ReadOnly = true;
            this.clmOdaNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYenile.Location = new System.Drawing.Point(612, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(107, 40);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Visible = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmResepsiyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgwResepsiyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmResepsiyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmResepsiyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResepsiyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwResepsiyon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriGirTar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriCikTar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOdaNo;
    }
}