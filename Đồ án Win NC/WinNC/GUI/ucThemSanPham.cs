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
    public partial class ucThemSanPham : UserControl
    {
        DataTable dtHoaDon = new DataTable();
        public ucThemSanPham()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ofdHinh.Title = "Chọn ảnh cho sản phẩm";
            ofdHinh.Filter = "*png|*.png|*jpg|*.jpg|*jpeg|*.jpeg|All Files|*.*";

            DialogResult d = ofdHinh.ShowDialog();
            if (d == DialogResult.OK)
            {
                lblDuongDan.Text = @"Data\SanPham\" + ofdHinh.FileName;
                picHinh.Image = Image.FromFile(ofdHinh.FileName);
                btnChonAnh.BackColor = Color.Silver;
                btnChonAnh.Text = "Đổi ảnh khác";

            }
        }

        private void ucThemSanPham_Load(object sender, EventArgs e)
        {
            
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtNVLap.Text = Program.NV_Login.HoTen;

            dtHoaDon.Columns.Add("TenHang");
            dtHoaDon.Columns.Add("NSX");
            dtHoaDon.Columns.Add("GiaNhapKho");
            dtHoaDon.Columns.Add("SoLuong");
            dtHoaDon.Columns.Add("ChatLieu");
            dtHoaDon.Columns.Add("Mau");
            dtHoaDon.Columns.Add("Size");
            dtHoaDon.Columns.Add("MaSP");
            dtHoaDon.Columns.Add("GiaBan");
            dtHoaDon.Columns.Add("LoaiSP");
            dtHoaDon.Columns.Add("GioiTinh");
            dtHoaDon.Columns.Add("Hinh");

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

            txtMa.Text = autoID_SP();
            List<clsSanPham_DTO> dsSP = clsSanPham_BUS.LayDSSPTheoTen(txtTenHang.Text);
            dgvTenHang.AutoGenerateColumns = false;
            dgvTenHang.DataSource = dsSP;
            resetControl();
        }

        private void dgvTenHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvTenHang.Rows[e.RowIndex].Height = 30;
        }

        private void dgvTenHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvTenHang.Rows[e.RowIndex];

            txtMa.Text = r.Cells[1].Value.ToString();
            cboLoai.SelectedValue = r.Cells[2].Value;
            cboNSX.SelectedValue = r.Cells[3].Value;
            string s = r.Cells[4].Value.ToString();
            radNam.Checked = (s == "Nam");
            radNu.Checked = !radNam.Checked;
            

            List<clsChiTietSanPham_DTO> dsChiTietSP = clsChiTietSanPham_BUS.LayDSCTSPTheoMaSP(r.Cells[1].Value.ToString());
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = dsChiTietSP;
            
            cboNSX.Enabled = cboLoai.Enabled = false;
            dgvTenHang.Visible = false;
            txtTenHang.Text = r.Cells[0].Value.ToString();
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(txtMa.Text, cboMau.SelectedValue.ToString(), cboChatLieu.SelectedValue.ToString(), cboSize.SelectedValue.ToString());
            if (ctsp.Count == 1)
            {
                lblWarning.Visible = true;
            }
            else
            {
                lblWarning.Visible = false;
            }

        }

        private void dgvChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTenHang.RowCount == 0)
            {
                return;
            }

            dgvChiTiet.Rows[e.RowIndex].Height = 70;

            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colMau")
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

            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colSize")
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

            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colChatLieu")
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

            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colHinh")
            {
                try
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
                catch
                {

                }
            }
        }

        string autoID_SP()
        {
            List<clsSanPham_DTO> dsSP = clsSanPham_BUS.RetrieveTable_SanPham(null);
            if (dsSP.Count <= 0)
            {
                return "1";
            }
            int max = Convert.ToInt32(dsSP[0].MaSP), n = dsSP.Count;
            for (int i = 1; i < n; i++)
            {
                int _id = Convert.ToInt32(dsSP[i].MaSP);
                if (max < _id)
                {
                    max = _id;
                }
            }

            return (max + 1).ToString();
        }

        string autoID_CTSP()
        {
            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "");
            if (dsSP.Count <= 0)
            {
                return "1";
            }
            int max = Convert.ToInt32(dsSP[0].MaSP), n = dsSP.Count;
            for (int i = 1; i < n; i++)
            {
                int _id = Convert.ToInt32(dsSP[i].MaChiTietSP);
                if (max < _id)
                {
                    max = _id;
                }
            }

            return (max + 1).ToString();
        }

        string autoID_HDNhap()
        {
            List<clsHoaDonNhap_DTO> dsSP = clsHoaDonNhap_BUS.LayDSHD("");
            if(dsSP.Count <= 0)
            {
                return "1";
            }
            int max = Convert.ToInt32(dsSP[0].MaHDNhap), n = dsSP.Count;
            for (int i = 1; i < n; i++)
            {
                int _id = Convert.ToInt32(dsSP[i].MaHDNhap);
                if (max < _id)
                {
                    max = _id;
                }
            }

            return (max + 1).ToString();
        }
        
        void getData(clsChiTietHDNhap_DTO cthd, clsChiTietSanPham_DTO ctsp, clsSanPham_DTO sp, int i)
        {
            sp.TenSP = dgvHoaDonNhap.Rows[i].Cells["colTen"].Value.ToString();
            int n = clsSanPham_BUS.DemSLSanPham(sp.TenSP);
            if(n == 0)
            {
                sp.MaSP = autoID_SP();
            }
            else
            {
                List<clsSanPham_DTO> SP = clsSanPham_BUS.LayDSSPTheoTen(sp.TenSP);
                sp.MaSP = SP[0].MaSP;
            }
            sp.MaLoaiSP = dgvHoaDonNhap.Rows[i].Cells["colLoaiSP"].Value.ToString();
            sp.MaNhaSX = dgvHoaDonNhap.Rows[i].Cells["colTenNSX"].Value.ToString();
            sp.NgayNhapKho = DateTime.Now;
            sp.GioiTinh = dgvHoaDonNhap.Rows[i].Cells["colGioiTinh"].Value.ToString();
            sp.TrangThai_SP = true;

            
            ctsp.MaSP = sp.MaSP;
            ctsp.MaMau = dgvHoaDonNhap.Rows[i].Cells["colMaMau"].Value.ToString();
            ctsp.MaChatLieu = dgvHoaDonNhap.Rows[i].Cells["colMaChatLieu"].Value.ToString();
            ctsp.MaSize = dgvHoaDonNhap.Rows[i].Cells["colMaSize"].Value.ToString();

            n = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(ctsp.MaSP, ctsp.MaMau, ctsp.MaChatLieu, ctsp.MaSize).Count;
            if(n == 0)
            {
                ctsp.MaChiTietSP = autoID_CTSP();
            }
            else
            {
                List<clsChiTietSanPham_DTO> CT = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(ctsp.MaSP, ctsp.MaMau, ctsp.MaChatLieu, ctsp.MaSize);
                ctsp.MaChiTietSP = CT[0].MaChiTietSP;
            }

            ctsp.GiaTien = Convert.ToInt32(dgvHoaDonNhap.Rows[i].Cells["colGiaBan"].Value.ToString());
            ctsp.HinhAnh = "Data\\AnhDaiDien\\" + ofdHinh.SafeFileName;
            ctsp.SoLuongTonKho = cthd.SoLuong;
            ctsp.TrangThai = true;

            cthd.MaChiTietSP = ctsp.MaChiTietSP;
            cthd.DonGia = Program.convertToInt(dgvHoaDonNhap.Rows[i].Cells["colGiaNhap"].Value.ToString());
            cthd.SoLuong = Program.convertToInt(dgvHoaDonNhap.Rows[i].Cells["colSoLuong"].Value.ToString());
            cthd.TrangThai = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if(txtGiaBan.Text == "")
            {
                lblGiaBan.ForeColor = Color.Red;
                check = false;
            }
            if(txtGiaNhap.Text == "")
            {
                lblGiaNhap.ForeColor = Color.Red;
                check = false;
            }
            if (txtTenHang.Text == "")
            {
                lblTenHang.ForeColor = Color.Red;
                check = false;
            }
            if (txtSoLuong.Text == "")
            {
                lblSoLuong.ForeColor = Color.Red;
                check = false;
            }
            if(picHinh.Image == null)
            {
                btnChonAnh.BackColor = Color.Tomato;
                check = false;
            }

            if(!check)
            {
                MessageBox.Show("Những vùng gạch chân đỏ là vùng bắt buộc. Vui lòng điền đầy đủ thông tin", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow r = dtHoaDon.NewRow();
            r["TenHang"] = txtTenHang.Text;
            r["NSX"] = cboNSX.SelectedValue.ToString();
            r["ChatLieu"] = cboChatLieu.SelectedValue.ToString();
            r["Mau"] = cboMau.SelectedValue.ToString();
            r["Size"] = cboSize.SelectedValue.ToString();
            r["GiaNhapKho"] = Program.convertToCurrency(Convert.ToInt32(txtGiaNhap.Text));
            r["SoLuong"] = Program.convertToCurrency(Convert.ToInt32(txtSoLuong.Text));
            r["MaSP"] = txtMa.Text;
            r["GiaBan"] = txtGiaBan.Text;
            r["LoaiSP"] = cboLoai.SelectedValue.ToString();
            r["GioiTinh"] = radNam.Checked ? "Nam" : "Nữ";
            r["Hinh"] = lblDuongDan.Text;

            if(dgvHoaDonNhap.Rows.Count == 0)
            {
                dtHoaDon.Rows.Add(r);
            }
            else
            {
                int n = dgvHoaDonNhap.Rows.Count;
                int i = 0;
                for (; i<n; i++)
                {
                    DataGridViewRow row = dgvHoaDonNhap.Rows[i];
                    if(r["MaSP"] == row.Cells["colMaSP"].Value.ToString() && r["Mau"] == row.Cells["colMaMau"].Value.ToString() && r["ChatLieu"] == row.Cells["colMaChatLieu"].Value.ToString() && r["Size"] == row.Cells["colMaSize"].Value.ToString())
                    {
                        dgvHoaDonNhap.Rows[i].Cells["colSoLuong"].Value = Convert.ToInt32(dgvHoaDonNhap.Rows[i].Cells["colSoLuong"].Value.ToString()) + Convert.ToInt32(r["SoLuong"]);
                        break;
                    }
                }
                if(i==n)
                {
                    dtHoaDon.Rows.Add(r);
                }
            }
            

            dgvHoaDonNhap.DataSource = dtHoaDon;
            dgvHoaDonNhap.AutoGenerateColumns = false;

            resetControl();
            MessageBox.Show("Đã thêm vào hàng chờ xử lý");
        }

        private void cboMau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(txtMa.Text, cboMau.SelectedValue.ToString(), cboChatLieu.SelectedValue.ToString(), cboSize.SelectedValue.ToString());
            if (ctsp.Count == 1)
            {
                lblWarning.Visible = true;
            }
            else
            {
                lblWarning.Visible = false;
                btnChonAnh.Enabled = true;
            }
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            dgvTenHang.Visible = true;
            List<clsSanPham_DTO> dsSP = clsSanPham_BUS.LayDSSPTheoTen(txtTenHang.Text);
            dgvTenHang.AutoGenerateColumns = false;
            dgvTenHang.DataSource = dsSP;
            dgvChiTiet.DataSource = null;
            dgvChiTiet.Rows.Clear();
            int sl = dsSP.Count;
            int n = clsSanPham_BUS.DemSLSanPham(txtTenHang.Text);
            cboLoai.Enabled = (n != 1);
            cboNSX.Enabled = (n != 1);
            radNam.Enabled = radNu.Enabled = cboNSX.Enabled;
            dgvTenHang.Visible = (dsSP.Count > 0);
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(txtMa.Text, cboMau.SelectedValue.ToString(), cboChatLieu.SelectedValue.ToString(), cboSize.SelectedValue.ToString());
        }

        private void txtTenHang_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtTenHang.Text == "")
                dgvTenHang.Visible = !dgvTenHang.Visible;
        }

        void ChangeTab(bool nhap, Color nhaphang, Color hoadon)
        {
            pnlHoaDonNhap.Visible = !nhap;
            pnlNhapHang.Visible = nhap;
            btnNhapHang.BackColor = nhaphang;
            btnNhapHang.FlatAppearance.MouseDownBackColor = nhaphang;
            btnNhapHang.FlatAppearance.MouseOverBackColor = nhaphang;
            btnHoaDonNhap.BackColor = hoadon;
            btnHoaDonNhap.FlatAppearance.MouseDownBackColor = hoadon;
            btnHoaDonNhap.FlatAppearance.MouseOverBackColor = hoadon;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ChangeTab(true, Color.White, Color.WhiteSmoke);
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            ChangeTab(false, Color.WhiteSmoke, Color.White);
        }

        private void pnlNhapHang_Click(object sender, EventArgs e)
        {
            dgvTenHang.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (Char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool check = true;
            string maHD = autoID_HDNhap();
            int n = dgvHoaDonNhap.Rows.Count;
            clsHoaDonNhap_DTO hd = new clsHoaDonNhap_DTO();
            hd.MaHDNhap = maHD;
            hd.MaNVLap = Program.NV_Login.MaNV;
            hd.NgayLapHD = DateTime.Now;
            hd.TrangThai = true;
            hd.TongTien = 0;
            if (clsHoaDonNhap_BUS.ThemHDNhap(hd))
            {
                for (int i = 0; i < n; i++)
                {
                    clsChiTietHDNhap_DTO cthd = new clsChiTietHDNhap_DTO();
                    clsChiTietSanPham_DTO ctsp = new clsChiTietSanPham_DTO();
                    clsSanPham_DTO sp = new clsSanPham_DTO();
                    getData(cthd, ctsp, sp, i);
                    cthd.MaHDNhap = hd.MaHDNhap;
                    List<clsChiTietSanPham_DTO> ct = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(sp.MaSP, ctsp.MaMau, ctsp.MaChatLieu, ctsp.MaSize);
                    if(ct.Count>0)
                    {
                        if (ct[0].MaSP != null)
                        {
                            if (clsChiTietSanPham_BUS.CapNhatSoLuong(ctsp.MaChiTietSP, cthd.SoLuong) && clsChiTietHDNhap_BUS.ThemChiTietHDNhap(cthd))
                            {
                                MessageBox.Show("Thêm số lượng thành công");
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }

                     }
                    else if(clsSanPham_BUS.DemSLSanPham(dgvHoaDonNhap.Rows[i].Cells["colTen"].Value.ToString()) > 0)
                    {
                        if (clsSanPham_BUS.Retrieve_SanPham(sp.MaSP).MaSP != null)
                        {
                            if (clsChiTietSanPham_BUS.ThemChiTietSP(ctsp) && clsChiTietHDNhap_BUS.ThemChiTietHDNhap(cthd))
                            {
                                MessageBox.Show("Thêm mẫu mã thành công");
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                    }

                    else if (clsSanPham_BUS.ThemSanPham(sp) && clsChiTietSanPham_BUS.ThemChiTietSP(ctsp) && clsChiTietHDNhap_BUS.ThemChiTietHDNhap(cthd))
                    {
                        MessageBox.Show("Thêm sản phẩm mới thành công");
                    }
                    else
                    {
                        check = false;
                    }

                }

                if (!check)
                {
                    MessageBox.Show("Thất bại");
                }
                else
                {
                    while (dgvHoaDonNhap.Rows.Count > 0)
                        dgvHoaDonNhap.Rows.Remove(dgvHoaDonNhap.Rows[0]);
                }
            }
            else
            {
                MessageBox.Show("Không thể tạo hóa đơn");
            }
            

        }

        private void dgvHoaDonNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvHoaDonNhap.RowCount <= 0)
            {
                return;
            }

            dgvHoaDonNhap.Rows[e.RowIndex].Height = 50;
            if (dgvHoaDonNhap.Columns[e.ColumnIndex].Name == "colMaMau")
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

            if (dgvHoaDonNhap.Columns[e.ColumnIndex].Name == "colMaSize")
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

            if (dgvHoaDonNhap.Columns[e.ColumnIndex].Name == "colMaChatLieu")
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

            if (dgvHoaDonNhap.Columns[e.ColumnIndex].Name == "colHinhAnh")
            {
                e.Value = new Bitmap(e.Value.ToString());
            }
        }

        private void dgvHoaDonNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(dgvHoaDonNhap.SelectedRows.Count > 0)
            {
                if(e.KeyChar == (Char)Keys.Delete)
                {
                    dgvHoaDonNhap.Rows.Remove(dgvHoaDonNhap.SelectedRows[0]);
                }
            }
        }

        void resetControl()
        {
            cboNSX.SelectedIndex = cboLoai.SelectedIndex = cboMau.SelectedIndex = cboChatLieu.SelectedIndex = cboSize.SelectedIndex = 1;
            txtTenHang.Text = txtGiaNhap.Text = txtGiaBan.Text = "";
            txtSoLuong.Text = "1";
            cboNSX.Enabled = cboLoai.Enabled = cboMau.Enabled = cboChatLieu.Enabled = cboSize.Enabled = true;
            dgvChiTiet.DataSource = null;
            dgvChiTiet.Rows.Clear();
            radNam.Checked = true;
            radNu.Checked = !radNam.Checked;
            lblWarning.Visible = false;
            dgvTenHang.Visible = false;
            picHinh.Image = null;
            btnChonAnh.Text = "Chọn ảnh";
            lblSoLuong.ForeColor = lblGiaNhap.ForeColor = lblGiaBan.ForeColor = lblTenHang.ForeColor = Color.Gray;
            btnChonAnh.BackColor = Color.Silver;
            btnChonAnh.Enabled = true;
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblDuongDan.Text = dgvChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString();
                picHinh.Image = Image.FromFile(dgvChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString());
                btnChonAnh.Enabled = false;
            }
            catch
            {

            }
            cboMau.SelectedValue = dgvChiTiet.Rows[e.RowIndex].Cells[0].Value;
            cboChatLieu.SelectedValue = dgvChiTiet.Rows[e.RowIndex].Cells[1].Value;
            cboSize.SelectedValue = dgvChiTiet.Rows[e.RowIndex].Cells[2].Value;
            lblWarning.Visible = true;
            
        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
