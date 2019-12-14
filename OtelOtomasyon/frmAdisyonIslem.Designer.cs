namespace OtelOtomasyon
{
    partial class frmAdisyonIslem
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
            this.gridAdisyon = new System.Windows.Forms.DataGridView();
            this.AdisyonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdisyonAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdisyonFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyon)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAdisyon
            // 
            this.gridAdisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdisyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdisyonID,
            this.AdisyonAd,
            this.AdisyonFiyat});
            this.gridAdisyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAdisyon.Location = new System.Drawing.Point(0, 40);
            this.gridAdisyon.Name = "gridAdisyon";
            this.gridAdisyon.Size = new System.Drawing.Size(451, 243);
            this.gridAdisyon.TabIndex = 0;
            this.gridAdisyon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAdisyon_CellEndEdit);
            // 
            // AdisyonID
            // 
            this.AdisyonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdisyonID.DataPropertyName = "AdisyonID";
            this.AdisyonID.HeaderText = "ID";
            this.AdisyonID.Name = "AdisyonID";
            this.AdisyonID.ReadOnly = true;
            // 
            // AdisyonAd
            // 
            this.AdisyonAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdisyonAd.DataPropertyName = "AdisyonAd";
            this.AdisyonAd.HeaderText = "Ad";
            this.AdisyonAd.Name = "AdisyonAd";
            // 
            // AdisyonFiyat
            // 
            this.AdisyonFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdisyonFiyat.DataPropertyName = "AdisyonFiyat";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.AdisyonFiyat.DefaultCellStyle = dataGridViewCellStyle1;
            this.AdisyonFiyat.HeaderText = "Birim Fiyatı";
            this.AdisyonFiyat.Name = "AdisyonFiyat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 40);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYenile.Location = new System.Drawing.Point(363, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(88, 40);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Visible = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmAdisyonIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 283);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridAdisyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdisyonIslem";
            this.Text = "Adisyon Listesi";
            this.Load += new System.EventHandler(this.frmAdisyonIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAdisyon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdisyonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdisyonAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdisyonFiyat;
    }
}