namespace BaiTap3_QuanLySVCNTT
{
    partial class frmQuanLySVCNTT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mtxtMSSV = new MaskedTextBox();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            cboLop = new ComboBox();
            mtxtSoDT = new MaskedTextBox();
            txtHinh = new TextBox();
            pbHinh = new PictureBox();
            btnChonHinh = new Button();
            btnMacDinh = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            lvSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            ctmsListView = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            tsmiTaiLai = new ToolStripMenuItem();
            ofdHinh = new OpenFileDialog();
            label1 = new Label();
            grbThongTin = new GroupBox();
            label5 = new Label();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbHinh).BeginInit();
            ctmsListView.SuspendLayout();
            grbThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // mtxtMSSV
            // 
            mtxtMSSV.Location = new Point(85, 31);
            mtxtMSSV.Mask = "0000000";
            mtxtMSSV.Name = "mtxtMSSV";
            mtxtMSSV.Size = new Size(321, 27);
            mtxtMSSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(85, 64);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(321, 27);
            txtHoTen.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(576, 29);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(186, 27);
            dtpNgaySinh.TabIndex = 1;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(576, 65);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 23);
            rdNam.TabIndex = 3;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(683, 65);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(51, 23);
            rdNu.TabIndex = 4;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(85, 130);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(321, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK43", "CTK44", "CTK45", "CTK46" });
            cboLop.Location = new Point(576, 97);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(186, 27);
            cboLop.TabIndex = 6;
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Location = new Point(576, 130);
            mtxtSoDT.Mask = "000\\.000\\.0000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(186, 27);
            mtxtSoDT.TabIndex = 8;
            // 
            // txtHinh
            // 
            txtHinh.Location = new Point(85, 163);
            txtHinh.Name = "txtHinh";
            txtHinh.ReadOnly = true;
            txtHinh.Size = new Size(569, 27);
            txtHinh.TabIndex = 9;
            // 
            // pbHinh
            // 
            pbHinh.Location = new Point(12, 12);
            pbHinh.Name = "pbHinh";
            pbHinh.Size = new Size(172, 238);
            pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinh.TabIndex = 10;
            pbHinh.TabStop = false;
            // 
            // btnChonHinh
            // 
            btnChonHinh.BackColor = SystemColors.GradientInactiveCaption;
            btnChonHinh.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnChonHinh.ForeColor = Color.DarkBlue;
            btnChonHinh.Location = new Point(660, 162);
            btnChonHinh.Name = "btnChonHinh";
            btnChonHinh.Size = new Size(102, 28);
            btnChonHinh.TabIndex = 10;
            btnChonHinh.Text = "Chọn hình";
            btnChonHinh.UseVisualStyleBackColor = false;
            btnChonHinh.Click += btnChonHinh_Click;
            // 
            // btnMacDinh
            // 
            btnMacDinh.BackColor = Color.MistyRose;
            btnMacDinh.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnMacDinh.ForeColor = Color.IndianRed;
            btnMacDinh.Location = new Point(351, 196);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(105, 29);
            btnMacDinh.TabIndex = 11;
            btnMacDinh.Text = "Mặc định";
            btnMacDinh.UseVisualStyleBackColor = false;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Honeydew;
            btnLuu.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnLuu.ForeColor = Color.DarkGreen;
            btnLuu.Location = new Point(520, 196);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LavenderBlush;
            btnThoat.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnThoat.ForeColor = Color.DeepPink;
            btnThoat.Location = new Point(660, 196);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvSinhVien.ContextMenuStrip = ctmsListView;
            lvSinhVien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(18, 295);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(934, 192);
            lvSinhVien.TabIndex = 1;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MSSV";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ và tên";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phái";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày sinh";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Lớp";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số điện thoại";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Địa chỉ";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Hình";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 120;
            // 
            // ctmsListView
            // 
            ctmsListView.ImageScalingSize = new Size(20, 20);
            ctmsListView.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, tsmiTaiLai });
            ctmsListView.Name = "ctmsListView";
            ctmsListView.Size = new Size(189, 52);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(188, 24);
            toolStripMenuItem1.Text = "Xóa";
            toolStripMenuItem1.Click += tsmiXoa_Click;
            // 
            // tsmiTaiLai
            // 
            tsmiTaiLai.Name = "tsmiTaiLai";
            tsmiTaiLai.Size = new Size(188, 24);
            tsmiTaiLai.Text = "Tải lại danh sách";
            tsmiTaiLai.Click += tsmiTaiLai_Click;
            // 
            // ofdHinh
            // 
            ofdHinh.FileName = "openFileDialog1";
            ofdHinh.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(5, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(btnThoat);
            grbThongTin.Controls.Add(cboLop);
            grbThongTin.Controls.Add(txtHinh);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(btnLuu);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(btnMacDinh);
            grbThongTin.Controls.Add(label1);
            grbThongTin.Controls.Add(btnChonHinh);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(mtxtMSSV);
            grbThongTin.Controls.Add(mtxtSoDT);
            grbThongTin.Controls.Add(txtHoTen);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(rdNu);
            grbThongTin.Controls.Add(rdNam);
            grbThongTin.Controls.Add(txtEmail);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(dtpNgaySinh);
            grbThongTin.Font = new Font("Times New Roman", 10.2F);
            grbThongTin.Location = new Point(190, 12);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(772, 238);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin sinh viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 4;
            label5.Text = "Hình";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label9.Location = new Point(469, 133);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 8;
            label9.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label8.Location = new Point(469, 105);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 7;
            label8.Text = "Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label7.Location = new Point(469, 72);
            label7.Name = "label7";
            label7.Size = new Size(43, 19);
            label7.TabIndex = 6;
            label7.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label6.Location = new Point(469, 34);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.Location = new Point(6, 133);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Times New Roman", 10.2F);
            groupBox1.Location = new Point(12, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên";
            // 
            // frmQuanLySVCNTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 505);
            Controls.Add(grbThongTin);
            Controls.Add(lvSinhVien);
            Controls.Add(pbHinh);
            Controls.Add(groupBox1);
            Name = "frmQuanLySVCNTT";
            Text = "Quản lý thông tin sinh viên khoa CNTT";
            FormClosing += frmQuanLySVCNTT_FormClosing;
            Load += frmQuanLySVCNTT_Load;
            ((System.ComponentModel.ISupportInitialize)pbHinh).EndInit();
            ctmsListView.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox mtxtMSSV;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private ComboBox cboLop;
        private MaskedTextBox mtxtSoDT;
        private TextBox txtHinh;
        private PictureBox pbHinh;
        private Button btnChonHinh;
        private Button btnMacDinh;
        private Button btnLuu;
        private Button btnThoat;
        private ListView lvSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ContextMenuStrip ctmsListView;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tsmiTaiLai;
        private OpenFileDialog ofdHinh;
        private Label label1;
        private GroupBox grbThongTin;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private GroupBox groupBox1;
    }
}
