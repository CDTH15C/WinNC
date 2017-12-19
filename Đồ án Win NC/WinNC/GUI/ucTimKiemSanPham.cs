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
    public partial class ucTimKiemSanPham : UserControl
    {
        public ucTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void ucTimKiemSanPham_Load(object sender, EventArgs e)
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

            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", "", "", "", false, 0, 0, 0, "");

            dgvSP.AutoGenerateColumns = false;
            dgvSP.DataSource = dsSP;
        }

        private void btnTimKiem_Enter(object sender, EventArgs e)
        {
           
        }

        private void dgvSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSP.Rows[e.RowIndex].Height = 50;

            if (dgvSP.Columns[e.ColumnIndex].Name == "colMau")
            {
                List<clsMau_DTO> dsMau = clsMau_BUS.Retrieve_Mau(null);
                foreach(clsMau_DTO mau in dsMau)
                {
                    if(e.Value.ToString().CompareTo(mau.MaMau) == 0)
                    {
                        e.Value = mau.TenMau;
                        break;
                    }
                } 
            }

            if (dgvSP.Columns[e.ColumnIndex].Name == "colSize")
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

            if (dgvSP.Columns[e.ColumnIndex].Name == "colTen")
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

            if (dgvSP.Columns[e.ColumnIndex].Name == "colChatLieu")
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

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMau = "", maCL = "", maSize = "", loaiSP = "";
            bool lonHon = false;
            int soLuong = 0, giaBanMin = 0, giaBanMax = 0;
            
            if(chkMau.Checked)
                maMau = cboMau.SelectedValue.ToString();

            if(chkChatLieu.Checked)
                maCL = cboChatLieu.SelectedValue.ToString();

            if(chkSize.Checked)
                maSize = cboSize.SelectedValue.ToString();

            if (chkLoai.Checked)
                loaiSP = cboLoai.SelectedValue.ToString();


            lonHon = radLonHon.Checked;
            
            if(txtSLTK.Text != "")
                soLuong = Convert.ToInt32(txtSLTK.Text);

            if (txtGiaMin.Text == "")
                giaBanMin = 0;
            else
                giaBanMin = Convert.ToInt32(txtGiaMin.Text);

            if(txtGiaMax.Text == "")
                giaBanMax = -1;
            else
                giaBanMax = Convert.ToInt32(txtGiaMax.Text);

            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham("", maMau, maCL, maSize, lonHon, soLuong, giaBanMin, giaBanMax, loaiSP);

            dgvSP.AutoGenerateColumns = false;
            dgvSP.DataSource = dsSP;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            string maMau = "", maCL = "", maSize = "", loaiSP = "" ;
            bool lonHon = false;
            int soLuong = 0, giaBanMin = 0, giaBanMax = 0;

            string tenSP = txtTen.Text;

            if (chkMau.Checked)
                maMau = cboMau.SelectedValue.ToString();

            if (chkChatLieu.Checked)
                maCL = cboChatLieu.SelectedValue.ToString();

            if (chkSize.Checked)
                maSize = cboSize.SelectedValue.ToString();

            if (chkLoai.Checked)
                loaiSP = cboLoai.SelectedValue.ToString();

            lonHon = radLonHon.Checked;
            try
            {
                soLuong = Convert.ToInt32(txtSLTK.Text);
            }
            catch
            {

            }

            giaBanMin = 0;
            giaBanMax = 0;

            List<clsChiTietSanPham_DTO> dsSP = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(tenSP, maMau, maCL, maSize, lonHon, soLuong, giaBanMin, giaBanMax, loaiSP);

            dgvSP.AutoGenerateColumns = false;
            dgvSP.DataSource = dsSP;
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtTen.Enabled = lblDashTen.Visible = chkTen.Checked;
        }

        private void chkMau_CheckedChanged(object sender, EventArgs e)
        {
            cboMau.Enabled = chkMau.Checked;
        }

        private void chkChatLieu_CheckedChanged(object sender, EventArgs e)
        {
            cboChatLieu.Enabled = chkChatLieu.Checked;
        }

        private void chkSize_CheckedChanged(object sender, EventArgs e)
        {
            cboSize.Enabled = chkSize.Checked;
        }

        private void chkLoai_CheckedChanged(object sender, EventArgs e)
        {
            cboLoai.Enabled = chkLoai.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            chkChatLieu.Checked = chkLoai.Checked = chkMau.Checked = chkSize.Checked = chkTen.Checked = false;
            cboChatLieu.SelectedIndex = cboLoai.SelectedIndex = cboMau.SelectedIndex = cboSize.SelectedIndex = 0;
            txtSLTK.Text = "0";
            txtTen.Text = "";
        }

        private void txtSLTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtSLTK.Text.Length > 6)
            {
                if (!(e.KeyChar == (Char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if(!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (Char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dgvSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            List<string> info = new List<string>();

            DataGridViewRow r = dgvSP.Rows[e.RowIndex];
            List<clsChiTietSanPham_DTO> ctsp = clsChiTietSanPham_BUS.Retrieve_ChiTietSanPham(r.Cells[0].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString());

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
    }
}
