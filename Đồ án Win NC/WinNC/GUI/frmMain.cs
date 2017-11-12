using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        int frmHeight, frmWidth;
        public frmMain()
        {
            InitializeComponent();
          
        }

        private void mnsSanPham_Click(object sender, EventArgs e)
        {
            
        }

        void LoadUcLogin()
        {
            frmHeight = this.Height;
            frmWidth = this.Width;
            UcLogin ucLg = new UcLogin();
            ucLg.Location = new Point(frmWidth / 2  - ucLg.Width/2, 100);
            pnlMain.Controls.Add(ucLg);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUcLogin();
        }

        private void mntQLTK_Click(object sender, EventArgs e)
        {
            ucAdmin ucAd = new ucAdmin();
            pnlMain.Controls.Clear();
            ucAd.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucAd);

        }

        private void mnsTimKiem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucSanPham ucSP = new ucSanPham();
            pnlMain.Controls.Add(ucSP);
            ucSP.Dock = DockStyle.Fill;
        }
    }
}
