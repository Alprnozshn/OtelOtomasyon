namespace OtelOtomasyon
{
    partial class frmMusteriAdisyon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMusteriAdisyon = new System.Windows.Forms.DataGridView();
            this.clmMusteri = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmAdisyon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmAdisyonAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmToplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriAdisyon)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMusteriAdisyon
            // 
            this.gridMusteriAdisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteriAdisyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMusteri,
            this.clmAdisyon,
            this.clmAdisyonAdet,
            this.clmToplamFiyat});
            this.gridMusteriAdisyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMusteriAdisyon.Location = new System.Drawing.Point(0, 56);
            this.gridMusteriAdisyon.Name = "gridMusteriAdisyon";
            this.gridMusteriAdisyon.Size = new System.Drawing.Size(800, 394);
            this.gridMusteriAdisyon.TabIndex = 0;
            this.gridMusteriAdisyon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMusteriAdisyon_CellEndEdit);
            // 
            // clmMusteri
            // 
            this.clmMusteri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMusteri.DataPropertyName = "MusteriID";
            this.clmMusteri.HeaderText = "Müşteri ";
            this.clmMusteri.Name = "clmMusteri";
            // 
            // clmAdisyon
            // 
            this.clmAdisyon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAdisyon.DataPropertyName = "AdisyonID";
            this.clmAdisyon.HeaderText = "Adisyon";
            this.clmAdisyon.Name = "clmAdisyon";
            // 
            // clmAdisyonAdet
            // 
            this.clmAdisyonAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAdisyonAdet.DataPropertyName = "AdisyonAdet";
            this.clmAdisyonAdet.HeaderText = "Adet";
            this.clmAdisyonAdet.Name = "clmAdisyonAdet";
            // 
            // clmToplamFiyat
            // 
            this.clmToplamFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmToplamFiyat.DataPropertyName = "AdisyonToplamFiyat";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.clmToplamFiyat.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmToplamFiyat.HeaderText = "Toplam Fiyat";
            this.clmToplamFiyat.Name = "clmToplamFiyat";
            this.clmToplamFiyat.ReadOnly = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 56);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYenile.Location = new System.Drawing.Point(632, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(168, 56);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Visible = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmMusteriAdisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridMusteriAdisyon);
            this.Name = "frmMusteriAdisyon";
            this.Text = "Müşteri Adisyon Listesi";
            this.Load += new System.EventHandler(this.frmMusteriAdisyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriAdisyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMusteriAdisyon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmMusteri;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmAdisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdisyonAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmToplamFiyat;
    }
}