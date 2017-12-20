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
    public partial class ucBanHang : UserControl
    {
        DataTable hdBan = new DataTable();
        public ucBanHang()
        {
            InitializeComponent();
        }

        private void ofdHinh_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSanPham.Rows[e.RowIndex].Height = 50;
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
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            hdBan.Columns.Add("TenHang");
            hdBan.Columns.Add("Mau");
            hdBan.Columns.Add("ChatLieu");
            hdBan.Columns.Add("Size");
            hdBan.Columns.Add("SoLuong");
            hdBan.Columns.Add("GiaBan");
            hdBan.Columns.Add("MaSP");
            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "", false, 0, 0, 0, "");

            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dsSP;
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(txtTenHang.Text, "", "", "", false, 0, 0, 0, "");

            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dsSP;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.LayDSCTSPTheoMaSP(txtMa.Text);
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dsSP;
        }

        private void radTenHang_CheckedChanged(object sender, EventArgs e)
        {
            txtTenHang.Enabled = lblTenHang.Visible = radTenHang.Checked;
            txtMa.Enabled = lblMa.Visible = !radTenHang.Checked;


        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            List<string> info = new List<string>();

            DataGridViewRow r = dgvSanPham.Rows[e.RowIndex];
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(r.Cells["colMa"].Value.ToString(), r.Cells["colMau"].Value.ToString(), r.Cells["colChatLieu"].Value.ToString(), r.Cells["colSize"].Value.ToString());

            info.Add(ctsp[0].MaSP);
            info.Add(ctsp[0].SoLuongTonKho.ToString());
            info.Add(ctsp[0].MaMau);
            info.Add(ctsp[0].MaSize);
            info.Add(ctsp[0].MaChatLieu);
            info.Add(ctsp[0].GiaTien.ToString());
            info.Add(ctsp[0].HinhAnh);

            frmChiTietSanPham frm = new frmChiTietSanPham(info);
            frm.ShowDialog();
        }

        string autoID_HoaDonBan()
        {
            List<clsHoaDonBan_DTO> dsCT = clsHoaDonBan_BUS.LayDSHDBan();
            if(dsCT.Count <= 0)
            {
                return "1";
            }
            int max = Convert.ToInt32(dsCT[0].MaHDBan);
            for (int i = 1; i<dsCT.Count; i++)
            {
                if(max < Convert.ToInt32(dsCT[i].MaHDBan))
                {
                    max = Convert.ToInt32(dsCT[i].MaHDBan);
                }
            }

            return (max+1).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTenHang.Text = "";
            radTenHang.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count <= 0)
            {
                return;
            }
            DataRow r = hdBan.NewRow();
            DataGridViewRow row = dgvSanPham.SelectedRows[0];
            r["TenHang"] = row.Cells["colTen"].Value.ToString();
            r["Mau"] = row.Cells["colMau"].Value.ToString();
            r["ChatLieu"] = row.Cells["colChatLieu"].Value.ToString();
            r["Size"] = row.Cells["colSize"].Value.ToString();
            r["SoLuong"] = Program.convertToCurrency(Convert.ToInt32(txtSoLuong.Text));
            r["GiaBan"] = Program.convertToCurrency((int)row.Cells["colGiaBan"].Value) + " VNĐ";
            r["MaSP"] = row.Cells["colMa"].Value.ToString();
            hdBan.Rows.Add(r);


            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = hdBan;
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Height = 50;
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colMauHD")
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

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colSizeHD")
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

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colChatLieuHD")
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

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colTenHD")
            {
                clsSanPham_DTO dsCL = clsSanPham_BUS.Retrieve_SanPham(e.Value.ToString());
                e.Value = dsCL.TenSP;
            }
        }

        void ChangeTab(bool nhap, Color nhaphang, Color hoadon)
        {
            pnlHoaDon.Visible = !nhap;
            pnlHoaDon.Visible = nhap;
            btnChonHang.BackColor = nhaphang;
            btnChonHang.FlatAppearance.MouseDownBackColor = nhaphang;
            btnChonHang.FlatAppearance.MouseOverBackColor = nhaphang;
            btnHoaDon.BackColor = hoadon;
            btnHoaDon.FlatAppearance.MouseDownBackColor = hoadon;
            btnHoaDon.FlatAppearance.MouseOverBackColor = hoadon;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            
            ChangeTab(false, Color.White, Color.WhiteSmoke);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            long s = 0;
            int n = dgvHoaDon.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                DataGridViewRow r = dgvHoaDon.Rows[i];
                s += Program.convertToInt(r.Cells["colSoLuongHD"].Value.ToString()) * Program.convertToInt(r.Cells["colGiaBanHD"].Value.ToString().Substring(0, r.Cells["colGiaBanHD"].Value.ToString().Length-4));
            }
            lblTongTien.Text = Program.convertToCurrency(s) + " VNĐ";
            ChangeTab(true, Color.WhiteSmoke, Color.White);
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            List<string> info = new List<string>();

            DataGridViewRow r = dgvHoaDon.Rows[e.RowIndex];
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(r.Cells["colMaSPHD"].Value.ToString(), r.Cells["colMauHD"].Value.ToString(), r.Cells["colChatLieuHD"].Value.ToString(), r.Cells["colSizeHD"].Value.ToString());

            info.Add(ctsp[0].MaSP);
            info.Add(ctsp[0].SoLuongTonKho.ToString());
            info.Add(ctsp[0].MaMau);
            info.Add(ctsp[0].MaSize);
            info.Add(ctsp[0].MaChatLieu);
            info.Add(ctsp[0].GiaTien.ToString());
            info.Add(ctsp[0].HinhAnh);

            frmChiTietSanPham frm = new frmChiTietSanPham(info);
            frm.ShowDialog();
        }

        void getData(clsHoaDonBan_DTO hd, clsChiTietHDBan_DTO cthd, int i)
        {
            DataGridViewRow r = dgvHoaDon.Rows[i];
            hd.MaHDBan = autoID_HoaDonBan();
            hd.MaNVLap = Program.NV_Login.MaNV;
            hd.NgayLapHD = DateTime.Now;
            hd.ThanhTien = Program.convertToInt(lblTongTien.Text.Substring(0, lblTongTien.Text.Length-4));
            hd.TrangThai = true;

            cthd.MaHDBan = hd.MaHDBan;
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(r.Cells["colMaSPHD"].Value.ToString(),r.Cells["colMauHD"].Value.ToString(), r.Cells["colChatLieuHD"].Value.ToString(), r.Cells["colSizeHD"].Value.ToString());
            cthd.MaChiTietSP = ctsp[0].MaChiTietSP;
            cthd.DonGia = Program.convertToInt(r.Cells["colGiaBanHD"].Value.ToString().Substring(0,r.Cells["colGiaBanHD"].Value.ToString().Length -4));
            cthd.SoLuong = Program.convertToInt(r.Cells["colSoLuongHD"].Value.ToString());
            cthd.TrangThai = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();
            clsChiTietHDBan_DTO cthd = new clsChiTietHDBan_DTO();

            int n = dgvHoaDon.Rows.Count;
            for(int i = 0; i<n; i++)
            {
                getData(hd, cthd, i);
                MessageBox.Show(cthd.DonGia.ToString() + ", " + cthd.MaHDBan + ", " + cthd.SoLuong.ToString());
            }
            
        }
        
    }
}
