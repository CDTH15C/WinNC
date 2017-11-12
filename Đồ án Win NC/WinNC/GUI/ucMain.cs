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
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void btnThemSanPham_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Button_enter.png");
            ((Button)sender).ForeColor = Color.White;
        }

        

        private void lblThemNhanhSP_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Underline);
        }

        private void lblThemNhanhSP_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
        }

        private void btnThemSanPham_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Image.FromFile("..\\..\\Resources\\IMG\\Icon\\Button.png");
            ((Button)sender).ForeColor = Color.DarkSlateGray;
        }

        private void ucMain_Load(object sender, EventArgs e)
        {

        }
    }
}
