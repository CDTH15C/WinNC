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

namespace GUI
{
    public partial class frmLogin : Form
    {
        Thread th;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void OpenNewForm(Object obj)
        {
            Application.Run(new frmMain());
        }
    }
}
