namespace OtelOtomasyon
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiris = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResepsiyon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResepsiyonPnl = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdisyon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKullaniciIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYetkiIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartman = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuResepsiyon,
            this.menuYonetim});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGiris,
            this.menuCikis});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuGiris
            // 
            this.menuGiris.Name = "menuGiris";
            this.menuGiris.Size = new System.Drawing.Size(121, 22);
            this.menuGiris.Text = "Giriş Yap";
            this.menuGiris.Click += new System.EventHandler(this.menuGiris_Click);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(121, 22);
            this.menuCikis.Text = "Çıkış Yap";
            this.menuCikis.Visible = false;
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuResepsiyon
            // 
            this.menuResepsiyon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResepsiyonPnl,
            this.müşteriİşlemleriToolStripMenuItem});
            this.menuResepsiyon.Name = "menuResepsiyon";
            this.menuResepsiyon.Size = new System.Drawing.Size(125, 20);
            this.menuResepsiyon.Text = "Resepsiyon İşlemleri";
            this.menuResepsiyon.Visible = false;
            // 
            // menuResepsiyonPnl
            // 
            this.menuResepsiyonPnl.Name = "menuResepsiyonPnl";
            this.menuResepsiyonPnl.Size = new System.Drawing.Size(180, 22);
            this.menuResepsiyonPnl.Text = "Resepsiyon Paneli";
            this.menuResepsiyonPnl.Click += new System.EventHandler(this.menuResepsiyonPnl_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMusteri,
            this.menuAdisyon});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(180, 22);
            this.menuMusteri.Text = "Müşteri İşlemleri";
            this.menuMusteri.Click += new System.EventHandler(this.menuMusteri_Click);
            // 
            // menuAdisyon
            // 
            this.menuAdisyon.Name = "menuAdisyon";
            this.menuAdisyon.Size = new System.Drawing.Size(180, 22);
            this.menuAdisyon.Text = "Adisyon İşlemleri";
            this.menuAdisyon.Click += new System.EventHandler(this.menuAdisyon_Click);
            // 
            // menuYonetim
            // 
            this.menuYonetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonel,
            this.menuKullanici,
            this.menuDepartman,
            this.menuOda});
            this.menuYonetim.Name = "menuYonetim";
            this.menuYonetim.Size = new System.Drawing.Size(108, 20);
            this.menuYonetim.Text = "Yönetici İşlemleri";
            this.menuYonetim.Visible = false;
            // 
            // menuPersonel
            // 
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(180, 22);
            this.menuPersonel.Text = "Personel İşlemleri";
            // 
            // menuKullanici
            // 
            this.menuKullanici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKullaniciIslem,
            this.menuYetkiIslem});
            this.menuKullanici.Name = "menuKullanici";
            this.menuKullanici.Size = new System.Drawing.Size(180, 22);
            this.menuKullanici.Text = "Kullanıcı İşlemleri";
            // 
            // menuKullaniciIslem
            // 
            this.menuKullaniciIslem.Name = "menuKullaniciIslem";
            this.menuKullaniciIslem.Size = new System.Drawing.Size(166, 22);
            this.menuKullaniciIslem.Text = "Kullanıcı İşlemleri";
            this.menuKullaniciIslem.Click += new System.EventHandler(this.menuKullaniciIslem_Click);
            // 
            // menuYetkiIslem
            // 
            this.menuYetkiIslem.Name = "menuYetkiIslem";
            this.menuYetkiIslem.Size = new System.Drawing.Size(166, 22);
            this.menuYetkiIslem.Text = "Yetki İşlemleri";
            this.menuYetkiIslem.Click += new System.EventHandler(this.menuYetkiIslem_Click);
            // 
            // menuDepartman
            // 
            this.menuDepartman.Name = "menuDepartman";
            this.menuDepartman.Size = new System.Drawing.Size(180, 22);
            this.menuDepartman.Text = "Departman İşlemleri";
            this.menuDepartman.Click += new System.EventHandler(this.menuDepartman_Click);
            // 
            // menuOda
            // 
            this.menuOda.Name = "menuOda";
            this.menuOda.Size = new System.Drawing.Size(180, 22);
            this.menuOda.Text = "Oda İşlemleri";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Ana Menü";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuResepsiyonPnl;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem menuAdisyon;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.ToolStripMenuItem menuKullanici;
        private System.Windows.Forms.ToolStripMenuItem menuDepartman;
        private System.Windows.Forms.ToolStripMenuItem menuOda;
        public System.Windows.Forms.MenuStrip menuMain;
        public System.Windows.Forms.ToolStripMenuItem menuResepsiyon;
        public System.Windows.Forms.ToolStripMenuItem menuYonetim;
        public System.Windows.Forms.ToolStripMenuItem menuCikis;
        public System.Windows.Forms.ToolStripMenuItem menuDosya;
        public System.Windows.Forms.ToolStripMenuItem menuGiris;
        private System.Windows.Forms.ToolStripMenuItem menuKullaniciIslem;
        private System.Windows.Forms.ToolStripMenuItem menuYetkiIslem;
    }
}