using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class ucSanPham : UserControl
    {
        List<LoaiSanPham_DTO> dsLoaiSanPham;
        List<Mau_DTO> dsMau;
        List<Size_DTO> dsSize;
        public ucSanPham()
        {

            InitializeComponent();
        }

        private void ucSanPham_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            List<string> condition = new List<string>();
            HienThiDsSanPham(condition);
            HienThiCboLoaiSanPham();
            HienThiCboMau("");
            HienThiCboSize("");
        }

        void HienThiCboLoaiSanPham()
        {
            LoaiSanPham_BUS obj = new LoaiSanPham_BUS();
            dsLoaiSanPham = obj.Retrieve_LoaiSanPham();
            cboLoaiSanPham.DataSource = dsLoaiSanPham;
            cboLoaiSanPham.DisplayMember = "TenLoaiSP";
            cboLoaiSanPham.ValueMember = "MaLoaiSP";
        }

        void HienThiCboMau(string condition)
        {
            Mau_BUS obj = new Mau_BUS();
            dsMau = obj.Retrieve_Mau(condition);
            cboMau.DataSource = dsMau;
            cboMau.DisplayMember = "TenMau";
            cboMau.ValueMember = "MaMau";
        }

        void HienThiCboSize(string condition)
        {
            Size_BUS obj = new Size_BUS();
            dsSize = obj.Retrieve_Size(condition);
            cboSize.DataSource = dsSize;
            cboSize.DisplayMember = "TenSize";
            cboSize.ValueMember = "MaSize";
        }

        void HienThiDsSanPham(List<string> condition)
        {
            List<SanPham_DTO> ds;
            SanPham_BUS obj = new SanPham_BUS();
            ds = obj.RetrieveTable_SanPham(condition);
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = ds;


            DataGridViewRow r = dgvSanPham.SelectedRows[0];
            string condition2 = r.Cells[0].Value.ToString();
            LoadHinhAnh(condition2);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                if ((string)e.Value == "Nam")
                {
                    e.Value = true;
                }
                else
                {
                    e.Value = false;
                }
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colMauSac")
            {
                
            }

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colSize")
            {

            }
        }
        void LoadHinhAnh(string condition)
        {
            HinhAnh_BUS obj = new HinhAnh_BUS();
            List<HinhAnh_DTO> dsHA = obj.Retrieve_HinhAnh(condition);
            string link = "";
            foreach (HinhAnh_DTO ha in dsHA)
            {
                link = ha.LinkAnh;
                break;
            }
            pctAnhSanPham.ImageLocation = link;
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvSanPham.SelectedRows[0];
            string condition = r.Cells[0].Value.ToString();
            LoadHinhAnh(condition);
        }
    }
}
