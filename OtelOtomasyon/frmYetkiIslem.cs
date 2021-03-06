﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Models;
using BLL;

namespace OtelOtomasyon
{
    public partial class frmYetkiIslem : Form
    {
        public frmYetkiIslem()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void frmYetkiIslem_Load(object sender, EventArgs e)
        {
            YetkiBL ybl = new YetkiBL();
            dt = ybl.YetkiListesi();
            gridYetki.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YetkiBL ybl = new YetkiBL();
            foreach (DataRow item in dt.Rows)
            {
                Yetki y = new Yetki();
                if (item.RowState != DataRowState.Deleted)
                {
                    y.YetkiAd = item[1].ToString();
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ybl.Ekle(y);
                        break;
                    case DataRowState.Deleted:
                        ybl.Sil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        y.YetkiID = Convert.ToInt32(item[0]);
                        ybl.Guncelle(y);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
