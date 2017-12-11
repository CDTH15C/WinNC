namespace GUI
{
    partial class ucHoaDonOption
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongKeHD = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSuaHD = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTimKiemHD = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaHD = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThongKeHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.btnSuaHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnTimKiemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnThemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.btnXoaHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thống kê";
            this.label3.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm kiếm";
            this.label2.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chỉnh sửa hóa đơn";
            this.label1.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // btnThongKeHD
            // 
            this.btnThongKeHD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThongKeHD.Controls.Add(this.label3);
            this.btnThongKeHD.Controls.Add(this.pictureBox3);
            this.btnThongKeHD.Location = new System.Drawing.Point(999, 286);
            this.btnThongKeHD.Name = "btnThongKeHD";
            this.btnThongKeHD.Size = new System.Drawing.Size(170, 181);
            this.btnThongKeHD.TabIndex = 10;
            this.btnThongKeHD.MouseEnter += new System.EventHandler(this.btnThemHD_MouseEnter);
            this.btnThongKeHD.MouseLeave += new System.EventHandler(this.btnThemHD_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.Thongke;
            this.pictureBox3.Location = new System.Drawing.Point(36, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaHD.Controls.Add(this.pictureBox1);
            this.btnSuaHD.Controls.Add(this.label1);
            this.btnSuaHD.Location = new System.Drawing.Point(823, 99);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(170, 181);
            this.btnSuaHD.TabIndex = 9;
            this.btnSuaHD.MouseEnter += new System.EventHandler(this.btnThemHD_MouseEnter);
            this.btnSuaHD.MouseLeave += new System.EventHandler(this.btnThemHD_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.ThemXoaSuaHoaDon;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTimKiemHD.Controls.Add(this.label2);
            this.btnTimKiemHD.Controls.Add(this.pictureBox2);
            this.btnTimKiemHD.Location = new System.Drawing.Point(647, 286);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(346, 181);
            this.btnTimKiemHD.TabIndex = 8;
            this.btnTimKiemHD.MouseEnter += new System.EventHandler(this.btnThemHD_MouseEnter);
            this.btnTimKiemHD.MouseLeave += new System.EventHandler(this.btnThemHD_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GUI.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(0, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(52, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Danh sách hóa đơn vừa lập";
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemHD.Controls.Add(this.pictureBox4);
            this.btnThemHD.Controls.Add(this.label5);
            this.btnThemHD.Location = new System.Drawing.Point(647, 99);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(170, 181);
            this.btnThemHD.TabIndex = 12;
            this.btnThemHD.MouseEnter += new System.EventHandler(this.btnThemHD_MouseEnter);
            this.btnThemHD.MouseLeave += new System.EventHandler(this.btnThemHD_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GUI.Properties.Resources.ThemHoaDon;
            this.pictureBox4.Location = new System.Drawing.Point(-10, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(202, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lập hóa đơn";
            this.label5.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaHD.Controls.Add(this.pictureBox5);
            this.btnXoaHD.Controls.Add(this.label7);
            this.btnXoaHD.Location = new System.Drawing.Point(999, 99);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(170, 181);
            this.btnXoaHD.TabIndex = 12;
            this.btnXoaHD.MouseEnter += new System.EventHandler(this.btnThemHD_MouseEnter);
            this.btnXoaHD.MouseLeave += new System.EventHandler(this.btnThemHD_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GUI.Properties.Resources.XoaHoaDon;
            this.pictureBox5.Location = new System.Drawing.Point(-7, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(202, 114);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(30, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hủy hóa đơn";
            this.label7.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(644, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chức năng";
            // 
            // ucHoaDonOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThongKeHD);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnTimKiemHD);
            this.Name = "ucHoaDonOption";
            this.Size = new System.Drawing.Size(1236, 642);
            this.btnThongKeHD.ResumeLayout(false);
            this.btnThongKeHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.btnSuaHD.ResumeLayout(false);
            this.btnSuaHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnTimKiemHD.ResumeLayout(false);
            this.btnTimKiemHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnThemHD.ResumeLayout(false);
            this.btnThemHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.btnXoaHD.ResumeLayout(false);
            this.btnXoaHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btnThongKeHD;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel btnSuaHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel btnTimKiemHD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel btnThemHD;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel btnXoaHD;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}
