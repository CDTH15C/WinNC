using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmLogin : Form
    {
        Thread th;
        NhanVien_DTO NV_Login;
        public frmLogin()
        {
            InitializeComponent();
        }
      
        private void btnThoat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void forgetPassword_Enter(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Underline);
        }

        private void forgetPassword_Leave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
        }

        void setNV(NhanVien_DTO nv)
        {
            Program.NV_Login = new NhanVien_DTO();
            Program.NV_Login.AnhDaiDien = nv.AnhDaiDien;
            Program.NV_Login.HoTen = nv.HoTen;
            Program.NV_Login.TenLoaiTK = nv.TenLoaiTK;
        }

        void XuLyDangNhap()
        {
            NhanVien_BUS obj = new NhanVien_BUS();
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("- Bạn chưa nhập tài khoản , mật khẩu ..!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (obj.KtraDangNhap(Username, Password))
                {
                    // lấy thông tin nhân viên .

                    NhanVien_BUS obj2 = new NhanVien_BUS();
                    NV_Login = obj2.LayThongTinNV(Username);
                    setNV(NV_Login);
                    // load frmMain
                    this.Close();
                    th = new Thread(OpenNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("- Sai thông tin tài khoản hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            XuLyDangNhap();
        }

        private void OpenNewForm(Object obj)
        {
            Application.Run(new frmMain());
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void lblHienThiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
