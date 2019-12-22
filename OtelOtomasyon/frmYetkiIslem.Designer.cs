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
            this.txtYetkiID = new CustomControlsLib.MyTextBox();
            this.txtYetkiAd = new CustomControlsLib.MyTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYetkiID
            // 
            this.txtYetkiID.CalismaModu = CustomControlsLib.WorkMode.Sayi;
            this.txtYetkiID.Location = new System.Drawing.Point(0, 3);
            this.txtYetkiID.Name = "txtYetkiID";
            this.txtYetkiID.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiID.TabIndex = 0;
            // 
            // txtYetkiAd
            // 
            this.txtYetkiAd.CalismaModu = CustomControlsLib.WorkMode.Harf;
            this.txtYetkiAd.Location = new System.Drawing.Point(0, 29);
            this.txtYetkiAd.Name = "txtYetkiAd";
            this.txtYetkiAd.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiAd.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(100, 97);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(100, 126);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(100, 184);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(100, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtYetkiAd);
            this.pnlText.Controls.Add(this.txtYetkiID);
            this.pnlText.Location = new System.Drawing.Point(90, 38);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(100, 53);
            this.pnlText.TabIndex = 8;
            // 
            // frmYetkiIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 246);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmYetkiIslem";
            this.Text = "frmYetkiIslem";
            this.Load += new System.EventHandler(this.frmYetkiIslem_Load);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomControlsLib.MyTextBox txtYetkiID;
        private CustomControlsLib.MyTextBox txtYetkiAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlText;
    }
}