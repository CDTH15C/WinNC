using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        // BtnDangNhap
        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien_BUS obj = new NhanVien_BUS();
            string TenTaiKhoan = txtTenTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
          if(obj.KtraDangNhap(TenTaiKhoan,MatKhau))
            {
                MessageBox.Show("Dang Nhap Thanh Cong...!");
            }
          else
            {
                MessageBox.Show("Dang Nhap That Bai...!");
            }
        }
    }
}
