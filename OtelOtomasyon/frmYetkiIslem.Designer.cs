namespace OtelOtomasyon
{
    partial class frmYetkiIslem
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
            this.gridYetki = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).BeginInit();
            this.SuspendLayout();
            // 
            // gridYetki
            // 
            this.gridYetki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridYetki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad});
            this.gridYetki.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridYetki.Location = new System.Drawing.Point(128, 0);
            this.gridYetki.Name = "gridYetki";
            this.gridYetki.Size = new System.Drawing.Size(361, 246);
            this.gridYetki.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "YetkiID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.DataPropertyName = "YetkiAd";
            this.Ad.HeaderText = "Yetki";
            this.Ad.Name = "Ad";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(26, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmYetkiIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridYetki);
            this.Name = "frmYetkiIslem";
            this.Text = "frmYetkiIslem";
            this.Load += new System.EventHandler(this.frmYetkiIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridYetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.Button btnKaydet;
    }
}