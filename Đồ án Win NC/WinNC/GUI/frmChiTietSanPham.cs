using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmChiTietSanPham : Form
    {
        List<string> info;

        public frmChiTietSanPham()
        {
            InitializeComponent();
        }

        public frmChiTietSanPham(List<string> Info)
        {
            info = Info;
            InitializeComponent();
        }

        private void picX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                lblMaSP.Text = "CHI TIẾT CỦA SẢN PHẨM MÃ: " + info[0];
                clsSanPham_DTO sp = clsSanPham_BUS.Retrieve_SanPham(info[0]);
                lblSLTK.Text = Program.convertToCurrency(Convert.ToInt32(info[1])) + " cái";
                lblTenSP.Text = sp.TenSP;

                List<clsNhaSanXuat_DTO> nsx = clsNhaSanXuat_BUS.LayDSNSX(sp.MaNhaSX);
                lblNSX.Text = nsx[0].TenNhaSX;
                
                clsMau_DTO mau = clsMau_BUS.LayMau(info[2]);
                lblMau.Text = mau.TenMau;

                clsSize_DTO size = clsSize_BUS.LaySize(info[3]);
                lblSize.Text = size.TenSize;

                clsChatLieu_DTO CL = clsChatLieu_BUS.LayDSChatLieu(info[4]);
                lblChatLieu.Text = CL.TenChatLieu;

                clsLoaiSanPham_DTO loai = clsLoaiSanPham_BUS.Retrieve_LoaiSanPham(sp.MaLoaiSP);
                lblLoaiSP.Text = loai.TenLoaiSP;

                lblGiaBan.Text = Program.convertToCurrency(Convert.ToInt32(info[5])) + " VNĐ / cái";

                lblNgayNhap.Text = sp.NgayNhapKho.ToString("dd/MM/yyyy");

                picHinhAnh.Image = Image.FromFile(info[6]);
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
