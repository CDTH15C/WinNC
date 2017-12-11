namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.pnlParent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.PictureBox();
            this.btnHoaDon = new System.Windows.Forms.PictureBox();
            this.btnSanPham = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.picX = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SlateGray;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.picX);
            this.pnlTop.Location = new System.Drawing.Point(-2, -2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1355, 31);
            this.pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CỬA HÀNG SUNFLOWER";
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // pnlParent
            // 
            this.pnlParent.Location = new System.Drawing.Point(51, 28);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1302, 916);
            this.pnlParent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Về màn hình chính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(74, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(74, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hóa đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(74, 638);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 20);
            this.label20.TabIndex = 8;
            this.label20.Text = "Đăng xuất";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMain.Controls.Add(this.label20);
            this.pnlMain.Controls.Add(this.btnDangXuat);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.btnHoaDon);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.btnSanPham);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnMainMenu);
            this.pnlMain.Location = new System.Drawing.Point(-2, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(55, 757);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::GUI.Properties.Resources.Logout;
            this.btnDangXuat.Location = new System.Drawing.Point(10, 630);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(33, 37);
            this.btnDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.TabStop = false;
            this.btnDangXuat.MouseEnter += new System.EventHandler(this.btnDangXuat_MouseEnter);
            this.btnDangXuat.MouseLeave += new System.EventHandler(this.btnDangXuat_MouseLeave);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Image = global::GUI.Properties.Resources.Bill;
            this.btnHoaDon.Location = new System.Drawing.Point(10, 140);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(33, 37);
            this.btnHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.TabStop = false;
            this.btnHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHoaDon_MouseClick);
            this.btnHoaDon.MouseEnter += new System.EventHandler(this.btnHoaDon_MouseEnter);
            this.btnHoaDon.MouseLeave += new System.EventHandler(this.btnHoaDon_MouseLeave);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Image = global::GUI.Properties.Resources.Product;
            this.btnSanPham.Location = new System.Drawing.Point(6, 70);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(41, 54);
            this.btnSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.TabStop = false;
            this.btnSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSanPham_MouseClick);
            this.btnSanPham.MouseEnter += new System.EventHandler(this.btnSanPham_MouseEnter);
            this.btnSanPham.MouseLeave += new System.EventHandler(this.btnSanPham_MouseLeave);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Image = global::GUI.Properties.Resources.ReturnToMainMenu;
            this.btnMainMenu.Location = new System.Drawing.Point(9, 22);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(33, 35);
            this.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMainMenu_MouseClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::GUI.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1282, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseClick);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // picX
            // 
            this.picX.Image = global::GUI.Properties.Resources.X_button_;
            this.picX.Location = new System.Drawing.Point(1308, -1);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(13, 31);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picX.TabIndex = 0;
            this.picX.TabStop = false;
            this.picX.Click += new System.EventHandler(this.picX_Click);
            this.picX.MouseEnter += new System.EventHandler(this.picX_MouseEnter);
            this.picX.MouseLeave += new System.EventHandler(this.picX_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1353, 711);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlParent);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.pnlTop_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.PictureBox btnMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnDangXuat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}