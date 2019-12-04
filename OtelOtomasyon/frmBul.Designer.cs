namespace OtelOtomasyon
{
    partial class frmBul
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
            this.txtTcKNo = new CustomControlsLib.MyTextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTcKNo
            // 
            this.txtTcKNo.CalismaModu = CustomControlsLib.WorkMode.Sayi;
            this.txtTcKNo.Location = new System.Drawing.Point(80, 12);
            this.txtTcKNo.Name = "txtTcKNo";
            this.txtTcKNo.Size = new System.Drawing.Size(123, 20);
            this.txtTcKNo.TabIndex = 0;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(85, 38);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Kimlik No";
            // 
            // frmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtTcKNo);
            this.Name = "frmBul";
            this.Text = "frmBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControlsLib.MyTextBox txtTcKNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
    }
}