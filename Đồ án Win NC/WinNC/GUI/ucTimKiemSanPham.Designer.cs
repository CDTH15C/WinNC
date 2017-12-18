namespace GUI
{
    partial class ucTimKiemSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radNhoHon = new System.Windows.Forms.RadioButton();
            this.radLonHon = new System.Windows.Forms.RadioButton();
            this.txtSLTK = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDashTen = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLoai = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkChatLieu = new System.Windows.Forms.CheckBox();
            this.chkMau = new System.Windows.Forms.CheckBox();
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.l.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.AllowUserToOrderColumns = true;
            this.dgvSP.AllowUserToResizeRows = false;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colCTSP,
            this.colTen,
            this.colMau,
            this.colChatLieu,
            this.colSize,
            this.colSLTK,
            this.colGiaBan});
            this.dgvSP.EnableHeadersVisualStyles = false;
            this.dgvSP.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSP.Location = new System.Drawing.Point(375, 100);
            this.dgvSP.MultiSelect = false;
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSP.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSP.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSP.Size = new System.Drawing.Size(901, 575);
            this.dgvSP.TabIndex = 75;
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellDoubleClick);
            this.dgvSP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSP_CellFormatting);
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaSP";
            this.colMa.HeaderText = "MaSP";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.Visible = false;
            // 
            // colCTSP
            // 
            this.colCTSP.DataPropertyName = "MaChiTietSanPham";
            this.colCTSP.HeaderText = "ChiTietSP";
            this.colCTSP.Name = "colCTSP";
            this.colCTSP.ReadOnly = true;
            this.colCTSP.Visible = false;
            // 
            // colTen
            // 
            this.colTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTen.DataPropertyName = "MaSP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTen.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTen.HeaderText = "Tên hàng";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colMau
            // 
            this.colMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMau.DataPropertyName = "MaMau";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMau.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMau.HeaderText = "Màu";
            this.colMau.Name = "colMau";
            this.colMau.ReadOnly = true;
            this.colMau.Width = 120;
            // 
            // colChatLieu
            // 
            this.colChatLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colChatLieu.DataPropertyName = "MaChatLieu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colChatLieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.colChatLieu.HeaderText = "Chất liệu";
            this.colChatLieu.Name = "colChatLieu";
            this.colChatLieu.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSize.DataPropertyName = "MaSize";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // colSLTK
            // 
            this.colSLTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSLTK.DataPropertyName = "SoLuongTonKho";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSLTK.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSLTK.HeaderText = "Số lượng tồn";
            this.colSLTK.Name = "colSLTK";
            this.colSLTK.ReadOnly = true;
            this.colSLTK.Width = 60;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGiaBan.DataPropertyName = "GiaTien";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,### VNĐ";
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle7;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Width = 120;
            // 
            // l
            // 
            this.l.Controls.Add(this.label4);
            this.l.Controls.Add(this.radNhoHon);
            this.l.Controls.Add(this.radLonHon);
            this.l.Controls.Add(this.txtSLTK);
            this.l.Controls.Add(this.label17);
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.l.Location = new System.Drawing.Point(36, 400);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(318, 106);
            this.l.TabIndex = 80;
            this.l.TabStop = false;
            this.l.Text = "Số lượng tồn kho";
            this.l.Enter += new System.EventHandler(this.btnTimKiem_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(255, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cái";
            // 
            // radNhoHon
            // 
            this.radNhoHon.AutoSize = true;
            this.radNhoHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhoHon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radNhoHon.Location = new System.Drawing.Point(30, 71);
            this.radNhoHon.Name = "radNhoHon";
            this.radNhoHon.Size = new System.Drawing.Size(80, 21);
            this.radNhoHon.TabIndex = 80;
            this.radNhoHon.Text = "Nhỏ hơn";
            this.radNhoHon.UseVisualStyleBackColor = true;
            // 
            // radLonHon
            // 
            this.radLonHon.AutoSize = true;
            this.radLonHon.Checked = true;
            this.radLonHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLonHon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radLonHon.Location = new System.Drawing.Point(30, 37);
            this.radLonHon.Name = "radLonHon";
            this.radLonHon.Size = new System.Drawing.Size(78, 21);
            this.radLonHon.TabIndex = 79;
            this.radLonHon.TabStop = true;
            this.radLonHon.Text = "Lớn hơn";
            this.radLonHon.UseVisualStyleBackColor = true;
            // 
            // txtSLTK
            // 
            this.txtSLTK.BackColor = System.Drawing.Color.White;
            this.txtSLTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSLTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSLTK.Location = new System.Drawing.Point(133, 54);
            this.txtSLTK.Name = "txtSLTK";
            this.txtSLTK.Size = new System.Drawing.Size(100, 19);
            this.txtSLTK.TabIndex = 77;
            this.txtSLTK.Text = "0";
            this.txtSLTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSLTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLTK_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(129, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 78;
            this.label17.Text = "_____________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTen);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.lblDashTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(36, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 79);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Định danh";
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Location = new System.Drawing.Point(16, 43);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(88, 22);
            this.chkTen.TabIndex = 76;
            this.chkTen.Text = "Tên hàng";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTen.Location = new System.Drawing.Point(119, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(169, 19);
            this.txtTen.TabIndex = 60;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // lblDashTen
            // 
            this.lblDashTen.AutoSize = true;
            this.lblDashTen.Location = new System.Drawing.Point(117, 47);
            this.lblDashTen.Name = "lblDashTen";
            this.lblDashTen.Size = new System.Drawing.Size(176, 18);
            this.lblDashTen.TabIndex = 61;
            this.lblDashTen.Text = "_____________________";
            this.lblDashTen.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLoai);
            this.groupBox3.Controls.Add(this.chkSize);
            this.groupBox3.Controls.Add(this.chkChatLieu);
            this.groupBox3.Controls.Add(this.chkMau);
            this.groupBox3.Controls.Add(this.cboMau);
            this.groupBox3.Controls.Add(this.cboChatLieu);
            this.groupBox3.Controls.Add(this.cboSize);
            this.groupBox3.Controls.Add(this.cboLoai);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(36, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 209);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // chkLoai
            // 
            this.chkLoai.AutoSize = true;
            this.chkLoai.Location = new System.Drawing.Point(16, 168);
            this.chkLoai.Name = "chkLoai";
            this.chkLoai.Size = new System.Drawing.Size(55, 22);
            this.chkLoai.TabIndex = 77;
            this.chkLoai.Text = "Loại";
            this.chkLoai.UseVisualStyleBackColor = true;
            this.chkLoai.CheckedChanged += new System.EventHandler(this.chkLoai_CheckedChanged);
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(16, 122);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(56, 22);
            this.chkSize.TabIndex = 76;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            this.chkSize.CheckedChanged += new System.EventHandler(this.chkSize_CheckedChanged);
            // 
            // chkChatLieu
            // 
            this.chkChatLieu.AutoSize = true;
            this.chkChatLieu.Location = new System.Drawing.Point(16, 80);
            this.chkChatLieu.Name = "chkChatLieu";
            this.chkChatLieu.Size = new System.Drawing.Size(84, 22);
            this.chkChatLieu.TabIndex = 75;
            this.chkChatLieu.Text = "Chất liệu";
            this.chkChatLieu.UseVisualStyleBackColor = true;
            this.chkChatLieu.CheckedChanged += new System.EventHandler(this.chkChatLieu_CheckedChanged);
            // 
            // chkMau
            // 
            this.chkMau.AutoSize = true;
            this.chkMau.Location = new System.Drawing.Point(16, 34);
            this.chkMau.Name = "chkMau";
            this.chkMau.Size = new System.Drawing.Size(56, 22);
            this.chkMau.TabIndex = 74;
            this.chkMau.Text = "Màu";
            this.chkMau.UseVisualStyleBackColor = true;
            this.chkMau.CheckedChanged += new System.EventHandler(this.chkMau_CheckedChanged);
            // 
            // cboMau
            // 
            this.cboMau.BackColor = System.Drawing.Color.White;
            this.cboMau.CausesValidation = false;
            this.cboMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMau.Enabled = false;
            this.cboMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMau.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Location = new System.Drawing.Point(122, 32);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(169, 26);
            this.cboMau.TabIndex = 68;
            // 
            // cboChatLieu
            // 
            this.cboChatLieu.BackColor = System.Drawing.Color.White;
            this.cboChatLieu.CausesValidation = false;
            this.cboChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChatLieu.Enabled = false;
            this.cboChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChatLieu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(122, 76);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.Size = new System.Drawing.Size(169, 26);
            this.cboChatLieu.TabIndex = 69;
            // 
            // cboSize
            // 
            this.cboSize.BackColor = System.Drawing.Color.White;
            this.cboSize.CausesValidation = false;
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.Enabled = false;
            this.cboSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(122, 120);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(169, 26);
            this.cboSize.TabIndex = 70;
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.White;
            this.cboLoai.CausesValidation = false;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Enabled = false;
            this.cboLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoai.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(122, 166);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(171, 26);
            this.cboLoai.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.dgvSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 724);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGiaMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(36, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 86);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giá bán trong khoảng giá (VNĐ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(141, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "đến";
            // 
            // txtGiaMax
            // 
            this.txtGiaMax.BackColor = System.Drawing.Color.White;
            this.txtGiaMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGiaMax.Location = new System.Drawing.Point(206, 43);
            this.txtGiaMax.Name = "txtGiaMax";
            this.txtGiaMax.Size = new System.Drawing.Size(100, 19);
            this.txtGiaMax.TabIndex = 79;
            this.txtGiaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "_____________";
            // 
            // txtGiaMin
            // 
            this.txtGiaMin.BackColor = System.Drawing.Color.White;
            this.txtGiaMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGiaMin.Location = new System.Drawing.Point(10, 43);
            this.txtGiaMin.Name = "txtGiaMin";
            this.txtGiaMin.Size = new System.Drawing.Size(100, 19);
            this.txtGiaMin.TabIndex = 77;
            this.txtGiaMin.Text = "0";
            this.txtGiaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "_____________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(372, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Kết quả tìm";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(1, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1333, 33);
            this.label20.TabIndex = 84;
            this.label20.Text = "TÌM KIẾM SẢN PHẨM";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(242, 604);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 71);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(36, 604);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 71);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ucTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucTimKiemSanPham";
            this.Size = new System.Drawing.Size(1311, 724);
            this.Load += new System.EventHandler(this.ucTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.l.ResumeLayout(false);
            this.l.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox l;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radNhoHon;
        private System.Windows.Forms.RadioButton radLonHon;
        private System.Windows.Forms.TextBox txtSLTK;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDashTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.ComboBox cboChatLieu;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkLoai;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkChatLieu;
        private System.Windows.Forms.CheckBox chkMau;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
    }
}
