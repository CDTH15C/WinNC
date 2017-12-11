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
            lblChucVu.Text = Program.NV_Login.TenLoaiTK;
            lblTenNV.Text = Program.NV_Login.HoTen;
        }
        void ThemListViewItem(HinhAnh_DTO ha, string condition)
        {
            var lvi = new ListViewItem(new[] { ha.SanPham.TenSP, ha.SanPham.GiaBan.ToString("#,### VNĐ") });
            //  var lvi = new ListViewItem(new[] { ha.TenSP, ha.GiaBan });
            // lvi.SubItems.Add(ha.MaSP.ToString());
            // lvi.SubItems.Add(ha.GiaBan.ToString("#,### VNĐ"));

            string url = ha.LinkAnh;

            if (condition == "BanChay")
            {
                if (url != "")
                {
                    Bitmap bm = new Bitmap(url);
                    imageList1.Images.Add(url, bm);
                    lvi.ImageKey = url;
                }
                lvwSPBanChay.Items.Add(lvi);
            }
            else
            {
                if (url != "")
                {
                    Bitmap bm = new Bitmap(url);
                    imageList2.Images.Add(url, bm);
                    lvi.ImageKey = url;
                }
                lvwSPBanCham.Items.Add(lvi);
            }
        }
        void LoadDuLieuChoListView_SPBanChay()
        {
            lvwSPBanChay.Items.Clear();
            List<HinhAnh_DTO> dsHA = new List<HinhAnh_DTO>();
            HinhAnh_BUS obj = new HinhAnh_BUS();
            string condition = "BanChay";
            dsHA = obj.layDsHinhAnh(condition);

            foreach (HinhAnh_DTO ha in dsHA)
            {
                ThemListViewItem(ha, condition);
            }
        }

        void LoadDuLieuChoListView_SPBanCham()
        {
            lvwSPBanCham.Items.Clear();
            List<HinhAnh_DTO> dsHA = new List<HinhAnh_DTO>();
            HinhAnh_BUS obj = new HinhAnh_BUS();
            string condition = "BanCham";
            dsHA = obj.layDsHinhAnh(condition);

            foreach (HinhAnh_DTO ha in dsHA)
            {
                ThemListViewItem(ha, condition);
            }
        }


        private void ucMain_Load(object sender, EventArgs e)
        {
            LoadThongTinNV();
            LoadDuLieuChoListView_SPBanChay();
            LoadDuLieuChoListView_SPBanCham();
        }

        private void lvwSPBanChay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwSPBanCham_SelectedIndexChanged(object sender, EventArgs e)
        {

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
