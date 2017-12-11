using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucSanPhamOption : UserControl
    {
        public ucSanPhamOption()
        {
            InitializeComponent();
        }
        private void btnThemHD_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.SteelBlue;
        }
        private void btnThemHD_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.DodgerBlue;
        }
        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.SteelBlue;
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.SteelBlue;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.DodgerBlue;
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.DodgerBlue;
        }

        private void btnThemHD_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
