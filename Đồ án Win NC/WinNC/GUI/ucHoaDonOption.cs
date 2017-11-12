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
    public partial class ucHoaDonOption : UserControl
    {
        public ucHoaDonOption()
        {
            InitializeComponent();
        }

        private void btnThemHD_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.SeaGreen;
        }
        private void btnThemHD_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.MediumSeaGreen;
        }
        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.SeaGreen;
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.SeaGreen;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.MediumSeaGreen;
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.MediumSeaGreen;
        }
    }
}