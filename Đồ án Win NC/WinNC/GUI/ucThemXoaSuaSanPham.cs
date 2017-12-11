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
    public partial class ucThemXoaSuaSanPham : UserControl
    {
        public ucThemXoaSuaSanPham()
        {
            InitializeComponent();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)(sender)).ForeColor = Color.White;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)(sender)).ForeColor = Color.Gray;
        }
    }
}
