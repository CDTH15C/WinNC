using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
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


        void LoadThongTinNV()
        {
            pctAvatar.ImageLocation = Program.NV_Login.AnhDaiDien;
            lblChucVu.Text = Program.NV_Login.ChucVu;
            lblTenNV.Text = Program.NV_Login.HoTen;
        }
      
        private void ucMain_Load(object sender, EventArgs e)
        {
            LoadThongTinNV();
        }

        private void lblThemNhanhSP_Click(object sender, EventArgs e)
        {
            frmThemNhanhSP frm = new frmThemNhanhSP();
            frm.ShowDialog();
        }
        
        private void lblLapNhanhHD_Click(object sender, EventArgs e)
        {

        }

        private void lblSPConKinhDoanh_Click(object sender, EventArgs e)
        {

        }
    }
}
