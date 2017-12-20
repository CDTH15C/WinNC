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

        void getData(clsChiTietSanPham_DTO ctsp, clsSanPham_DTO sp)
        {
            ctsp.MaSP = lblMa.Text;
            ctsp.MaMau = cboMau.SelectedValue.ToString();
            ctsp.MaChatLieu = cboChatLieu.SelectedValue.ToString();
            ctsp.MaSize = cboSize.SelectedValue.ToString();
            ctsp.HinhAnh = lblDuongDan.Text;
            ctsp.SoLuongTonKho = Program.convertToInt(lblSLTK.Text);
            ctsp.TrangThai = true;

            sp.MaSP = ctsp.MaSP;
            clsSanPham_DTO SP = clsSanPham_BUS.Retrieve_SanPham(sp.MaSP);
            sp.NgayNhapKho = SP.NgayNhapKho;
            sp.MaLoaiSP = cboLoai.SelectedValue.ToString();
            sp.TenSP = txtTenHang.Text;
            sp.MaNhaSX = cboNSX.SelectedValue.ToString();
            sp.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            sp.TrangThai_SP = true;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clsSanPham_DTO sp = new clsSanPham_DTO();
            clsChiTietSanPham_DTO ctsp = new clsChiTietSanPham_DTO();
            getData(ctsp, sp);
            if (clsSanPham_BUS.CapNhatSanPham(sp))
            {
                if (clsChiTietSanPham_BUS.CapNhatCTSP(ctsp))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "", false, 0, 0, 0, "");

                    dgvSanPham.AutoGenerateColumns = false;
                    dgvSanPham.DataSource = dsSP;
                    resetControl();
                }
            }
        }

        void XoaSP()
        {
            if (clsChiTietSanPham_BUS.CapNhatTrangThai(false, lblMa.Text, cboMau.SelectedValue.ToString(), cboChatLieu.SelectedValue.ToString(), cboSize.SelectedValue.ToString()))
            {
                List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "", false, 0, 0, 0, "");

                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = dsSP;
                MessageBox.Show("Đã xóa thành công sản phẩm " + txtTenHang.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetControl();
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

            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "", false, 0, 0, 0, "");

            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dsSP;
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSanPham.Rows[e.RowIndex].Height = 40;

            if(dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh")
            {
                e.Value = new Bitmap(e.Value.ToString());
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colMau")
            {
                List<clsMau_DTO> dsMau = clsMau_BUS.Retrieve_Mau(null);
                foreach (clsMau_DTO mau in dsMau)
                {
                    if (e.Value.ToString().CompareTo(mau.MaMau) == 0)
                    {
                        e.Value = mau.TenMau;
                        break;
                    }
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colSize")
            {
                List<clsSize_DTO> dsSize = clsSize_BUS.Retrieve_Size(null);
                foreach (clsSize_DTO size in dsSize)
                {
                    if (e.Value.ToString().CompareTo(size.MaSize) == 0)
                    {
                        e.Value = size.TenSize;
                        break;
                    }
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colTen")
            {
                List<clsSanPham_DTO> dsSP = clsSanPham_BUS.RetrieveTable_SanPham(null);
                foreach (clsSanPham_DTO SP in dsSP)
                {
                    if (e.Value.ToString().CompareTo(SP.MaSP) == 0)
                    {
                        e.Value = SP.TenSP;
                        break;
                    }
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                List<clsSanPham_DTO> dsSP = clsSanPham_BUS.RetrieveTable_SanPham(null);
                foreach (clsSanPham_DTO SP in dsSP)
                {
                    if (e.Value.ToString().CompareTo(SP.MaSP) == 0)
                    {
                        e.Value = SP.GioiTinh;
                        break;
                    }
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colChatLieu")
            {
                List<clsChatLieu_DTO> dsCL = clsChatLieu_BUS.LayDSChatLieu();
                foreach (clsChatLieu_DTO CL in dsCL)
                {
                    if (e.Value.ToString().CompareTo(CL.MaChatLieu) == 0)
                    {
                        e.Value = CL.TenChatLieu;
                        break;
                    }
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colLoai")
            {
                clsSanPham_DTO sp = clsSanPham_BUS.Retrieve_SanPham(dgvSanPham.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
                e.Value = sp.MaLoaiSP;
                List<clsLoaiSanPham_DTO> dsCL = clsLoaiSanPham_BUS.Retrieve_LoaiSanPham();
                foreach (clsLoaiSanPham_DTO CL in dsCL)
                {
                    if (e.Value.ToString().CompareTo(CL.MaLoaiSP) == 0)
                    {
                        e.Value = CL.TenLoaiSP;
                        break;
                    }
                }
            }
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            //List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(txtTenHang.Text, "", "", "", false, 0, 0, 0, "");

            //dgvSanPham.AutoGenerateColumns = false;
            //dgvSanPham.DataSource = dsSP;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            btnXoa.Enabled = btnSua.Enabled = true;

            DataGridViewRow r = dgvSanPham.Rows[e.RowIndex];
            lblMa.Text = r.Cells["colMa"].Value.ToString();
            cboMau.SelectedValue = r.Cells["colMau"].Value;
            cboChatLieu.SelectedValue = r.Cells["colChatLieu"].Value;
            cboSize.SelectedValue = r.Cells["colSize"].Value;

            clsSanPham_DTO SP = clsSanPham_BUS.Retrieve_SanPham(lblMa.Text);
            txtTenHang.Text = SP.TenSP;
            radNam.Checked = SP.GioiTinh.CompareTo("Nam") == 0;
            lblNgayNhap.Text = SP.NgayNhapKho.ToString("dd/MM/yyyy");
            cboLoai.SelectedValue = SP.MaLoaiSP;
            cboNSX.SelectedValue = SP.MaNhaSX;

            txtGiaBan.Text = Program.convertToCurrency((int)r.Cells["colGiaBan"].Value);
            picHinh.Image = Image.FromFile(r.Cells["colHinh"].Value.ToString());
            lblSLTK.Text = Program.convertToCurrency((int)r.Cells["colSoLuong"].Value);
            radNu.Checked = !radNam.Checked;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ofdHinh.Title = "Chọn ảnh cho sản phẩm";
            ofdHinh.Filter = "*png|*.png|*jpg|*.jpg|*jpeg|*.jpeg|All Files|*.*";

            DialogResult d = ofdHinh.ShowDialog();
            if (d == DialogResult.OK)
            {
                lblDuongDan.Text = @"Data\SanPham\" + ofdHinh.SafeFileName;
                picHinh.Image = Image.FromFile(ofdHinh.FileName);
                btnChonAnh.BackColor = Color.Silver;
                btnChonAnh.Text = "Đổi ảnh khác";

            }
        }

        void resetControl()
        {
            cboChatLieu.SelectedIndex = cboLoai.SelectedIndex = cboMau.SelectedIndex = cboNSX.SelectedIndex = cboSize.SelectedIndex = 0;
            txtTenHang.Text = txtGiaBan.Text = "";
            lblMa.Text = lblNgayNhap.Text = lblSLTK.Text = "";
            picHinh.Image = null;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetControl();
        }
    }
}
