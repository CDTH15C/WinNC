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
        int pnlMinWidth = 56, pnlMaxWidth = 287;
        int delta = 10;

        public frmMain()
        {
            InitializeComponent();
        }

        #region FlatDesign

        private void picX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.No)
                e.Cancel = true;
        }
        private void picX_MouseEnter(object sender, EventArgs e)
        {
            picX.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\X-button_enter.png");
        }
        private void pnlTop_Load(object sender, EventArgs e)
        {
            pnlTop.Width = this.Size.Width + 2;
            picX.Location = new Point(pnlTop.Width - 40, pnlTop.Height - 29);
            btnMinimize.Location = new Point(picX.Location.X - 40, picX.Location.Y);

            ucMain uc = new ucMain();
            //uc.Location = new Point(0, 20);
            pnlParent.Controls.Add(uc);
            uc.Show();

        }
        private void picX_MouseLeave(object sender, EventArgs e)
        {
            picX.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\X-button_.png");
        }
        private void picButtonExpandShrink_MouseClick(object sender, MouseEventArgs e)
        {
            timerMain.Start();
            if (pnlMain.Width < pnlMaxWidth)
            {
                isExpand = true;
                isShrink = false;
            }

            else
            {
                isExpand = false;
                isShrink = true;
            }
        }
        private void btnSanPham_MouseClick(object sender, MouseEventArgs e)
        {
            pnlParent.Controls.Clear();
            ucTimKiemSanPham uc = new ucTimKiemSanPham();
            uc.Location = new Point(0, 0);
            pnlParent.Controls.Add(uc);
            uc.Show();

        }
        private void btnDangXuat_MouseEnter(object sender, EventArgs e)
        {
            btnDangXuat.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Logout_enter.png");
        }
        private void btnHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            pnlParent.Controls.Clear();
            ucHoaDonOption uc = new ucHoaDonOption();
            uc.Location = new Point(0, 20);
            pnlParent.Controls.Add(uc);
            uc.Show();
        }
        private void btnMainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            pnlParent.Controls.Clear();
            ucMain uc = new ucMain();
           // uc.Location = new Point(0, 20);
            pnlParent.Controls.Add(uc);
            uc.Show();
        }
        private void btnDangXuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangXuat.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Logout.png");
        }
        private void btnSanPham_MouseEnter(object sender, EventArgs e)
        {
            btnSanPham.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Product_enter.png");
        }
        private void btnSanPham_MouseLeave(object sender, EventArgs e)
        {
            btnSanPham.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Product.png");
        }
        private void btnHoaDon_MouseEnter(object sender, EventArgs e)
        {
            btnHoaDon.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Bill_enter.png");
        }
        private void btnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            btnHoaDon.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Bill.png");
        }
        
        #region Time Tick

        bool isShrink, isExpand;

        #region Expand + Shrink
        void ShrinkPanelMain()
        {
            pnlMain.Width -= delta;
            if (pnlMain.Width <= pnlMinWidth)
            {
                pnlMain.Width = pnlMinWidth;
                timerMain.Stop();

                isShrink = false;
            }
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            timerMain.Start();
            if (pnlMain.Width < pnlMaxWidth)
            {
                isExpand = true;
                isShrink = false;
            }

            else
            {
                isExpand = false;
                isShrink = true;
            }
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\minimize_enter.png");
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\minimize.png");
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void ExpandPanelMain()
        {
            pnlMain.Width += delta;
            if (pnlMain.Width >= pnlMaxWidth)
            {
                pnlMain.Width = pnlMaxWidth;
                timerMain.Stop();

                isExpand = false;
            }
        }
        #endregion
        
        private void timerMain_Tick(object sender, EventArgs e)
        {
            timerMain.Interval = 1;

            if (isShrink)
                ShrinkPanelMain();
            if(isExpand)
                ExpandPanelMain();
        }

        #endregion

        #endregion


    }
}
