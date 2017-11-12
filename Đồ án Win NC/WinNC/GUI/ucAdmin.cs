using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }

        private void ucAdmin_Load(object sender, EventArgs e)
        {
            /* List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();
             NhanVien_BUS obj = new NhanVien_BUS();
             dsNV = obj.LayDsNV();
             dgvListNV.DataSource = dsNV; */
            List<string> condition = new List<string>();
            List<SanPham_DTO> ds;
            SanPham_BUS obj = new SanPham_BUS();
            ds = obj.RetrieveTable_SanPham(condition);
           // dgvListNV.AutoGenerateColumns = false;
            dgvListNV.DataSource = ds;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
