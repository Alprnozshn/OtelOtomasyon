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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResepsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwResepsiyon
            // 
            this.dgwResepsiyon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwResepsiyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResepsiyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwResepsiyon.Location = new System.Drawing.Point(0, 40);
            this.dgwResepsiyon.Name = "dgwResepsiyon";
            this.dgwResepsiyon.Size = new System.Drawing.Size(746, 410);
            this.dgwResepsiyon.TabIndex = 1;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMusteri.Location = new System.Drawing.Point(0, 0);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(115, 40);
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "Müşteri İşlemleri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYenile.Location = new System.Drawing.Point(115, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(107, 40);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOturumKapat.Location = new System.Drawing.Point(639, 0);
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.Size = new System.Drawing.Size(107, 40);
            this.btnOturumKapat.TabIndex = 3;
            this.btnOturumKapat.Text = "Giriş Ekranına Dön";
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // frmResepsiyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnOturumKapat);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.dgwResepsiyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmResepsiyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResepsiyon";
            this.Load += new System.EventHandler(this.frmResepsiyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResepsiyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwResepsiyon;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnOturumKapat;
    }
}