namespace OtelOtomasyon
{
    partial class frmAdisyonPnl
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
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnMusteriAdisyon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyon.Location = new System.Drawing.Point(0, 0);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(232, 55);
            this.btnAdisyon.TabIndex = 0;
            this.btnAdisyon.Text = "Adisyon İşlemleri";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnMusteriAdisyon
            // 
            this.btnMusteriAdisyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMusteriAdisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriAdisyon.Location = new System.Drawing.Point(0, 55);
            this.btnMusteriAdisyon.Name = "btnMusteriAdisyon";
            this.btnMusteriAdisyon.Size = new System.Drawing.Size(232, 55);
            this.btnMusteriAdisyon.TabIndex = 1;
            this.btnMusteriAdisyon.Text = "Müşteri Adisyon İşlemleri";
            this.btnMusteriAdisyon.UseVisualStyleBackColor = true;
            this.btnMusteriAdisyon.Click += new System.EventHandler(this.btnMusteriAdisyon_Click);
            // 
            // frmAdisyonPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 110);
            this.Controls.Add(this.btnMusteriAdisyon);
            this.Controls.Add(this.btnAdisyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdisyonPnl";
            this.Text = "Adisyon Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnMusteriAdisyon;
    }
}