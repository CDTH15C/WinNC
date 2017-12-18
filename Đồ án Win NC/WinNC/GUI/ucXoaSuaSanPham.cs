using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ucXoaSuaSanPham : UserControl
    {
        public ucXoaSuaSanPham()
        {
            InitializeComponent();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)(sender)).ForeColor = Color.White;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
           // ((Button)(sender)).ForeColor = Color.Gray;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        void XoaSP()
        {
            if (clsChiTietSanPham_BUS.CapNhatTrangThai(false, lblMa.Text, cboMau.SelectedValue.ToString(), cboChatLieu.SelectedValue.ToString(), cboSize.SelectedValue.ToString()))
            {
                MessageBox.Show("Đã xóa thành công sản phẩm " + txtTenHang.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSP();
        }

        private void dgvSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Delete)
            {
                XoaSP();
            }
        }

        private void ucXoaSuaSanPham_Load(object sender, EventArgs e)
        {
            List<clsMau_DTO> dsMau = clsMau_BUS.Retrieve_Mau(null);
            cboMau.DataSource = dsMau;
            cboMau.ValueMember = "MaMau";
            cboMau.DisplayMember = "TenMau";

            List<clsSize_DTO> dsSize = clsSize_BUS.Retrieve_Size(null);
            cboSize.DataSource = dsSize;
            cboSize.ValueMember = "MaSize";
            cboSize.DisplayMember = "TenSize";

            List<clsChatLieu_DTO> dsChatLieu = clsChatLieu_BUS.LayDSChatLieu();
            cboChatLieu.DataSource = dsChatLieu;
            cboChatLieu.ValueMember = "MaChatLieu";
            cboChatLieu.DisplayMember = "TenChatLieu";

            List<clsLoaiSanPham_DTO> dsLoaiSP = clsLoaiSanPham_BUS.Retrieve_LoaiSanPham();
            cboLoai.DataSource = dsLoaiSP;
            cboLoai.ValueMember = "MaLoaiSP";
            cboLoai.DisplayMember = "TenLoaiSP";

            List<clsNhaSanXuat_DTO> dsNSX = clsNhaSanXuat_BUS.LayDSNSX("");
            cboNSX.DataSource = dsNSX;
            cboNSX.ValueMember = "MaNhaSX";
            cboNSX.DisplayMember = "TenNhaSX";
        }
    }
}
