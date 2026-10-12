namespace MyForm
{
    partial class frmSinhVien
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            splitContainer1 = new SplitContainer();
            groupboxTTSV = new GroupBox();
            btnThoat = new Button();
            btnMacDinh = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            clbChuyenNganh = new CheckedListBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            pbHinh = new PictureBox();
            btnBrowse = new Button();
            txtHinh = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cboLop = new ComboBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            mtxtMaSo = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            sửaToolStripMenuItem = new ToolStripMenuItem();
            sửaToolStripMenuItem1 = new ToolStripMenuItem();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            màuChữToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslTongSV = new ToolStripStatusLabel();
            groupboxDSSV = new GroupBox();
            lvSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            OpenFileDialogHinh = new OpenFileDialog();
            ctmsListView = new ContextMenuStrip(components);
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            màuChữToolStripMenuItem1 = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem1 = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupboxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinh).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupboxDSSV.SuspendLayout();
            ctmsListView.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupboxTTSV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Panel2.Controls.Add(groupboxDSSV);
            splitContainer1.Size = new Size(1292, 567);
            splitContainer1.SplitterDistance = 545;
            splitContainer1.TabIndex = 0;
            // 
            // groupboxTTSV
            // 
            groupboxTTSV.Controls.Add(btnThoat);
            groupboxTTSV.Controls.Add(btnMacDinh);
            groupboxTTSV.Controls.Add(btnSua);
            groupboxTTSV.Controls.Add(btnXoa);
            groupboxTTSV.Controls.Add(btnThem);
            groupboxTTSV.Controls.Add(clbChuyenNganh);
            groupboxTTSV.Controls.Add(rdNu);
            groupboxTTSV.Controls.Add(rdNam);
            groupboxTTSV.Controls.Add(pbHinh);
            groupboxTTSV.Controls.Add(btnBrowse);
            groupboxTTSV.Controls.Add(txtHinh);
            groupboxTTSV.Controls.Add(label8);
            groupboxTTSV.Controls.Add(label7);
            groupboxTTSV.Controls.Add(label6);
            groupboxTTSV.Controls.Add(cboLop);
            groupboxTTSV.Controls.Add(txtDiaChi);
            groupboxTTSV.Controls.Add(dtpNgaySinh);
            groupboxTTSV.Controls.Add(txtHoTen);
            groupboxTTSV.Controls.Add(mtxtMaSo);
            groupboxTTSV.Controls.Add(label5);
            groupboxTTSV.Controls.Add(label4);
            groupboxTTSV.Controls.Add(label3);
            groupboxTTSV.Controls.Add(label2);
            groupboxTTSV.Controls.Add(label1);
            groupboxTTSV.Controls.Add(menuStrip1);
            groupboxTTSV.Location = new Point(3, 3);
            groupboxTTSV.Name = "groupboxTTSV";
            groupboxTTSV.Size = new Size(543, 564);
            groupboxTTSV.TabIndex = 0;
            groupboxTTSV.TabStop = false;
            groupboxTTSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.OldLace;
            btnThoat.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Maroon;
            btnThoat.Location = new Point(445, 518);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(77, 34);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnMacDinh
            // 
            btnMacDinh.BackColor = Color.LavenderBlush;
            btnMacDinh.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnMacDinh.ForeColor = Color.PaleVioletRed;
            btnMacDinh.Location = new Point(329, 518);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(94, 34);
            btnMacDinh.TabIndex = 15;
            btnMacDinh.Text = "Mặc định";
            btnMacDinh.UseVisualStyleBackColor = false;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MintCream;
            btnSua.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.DarkCyan;
            btnSua.Location = new Point(221, 518);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(81, 34);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Snow;
            btnXoa.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(115, 518);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 34);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightYellow;
            btnThem.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.DarkGoldenrod;
            btnThem.Location = new Point(9, 518);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 34);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // clbChuyenNganh
            // 
            clbChuyenNganh.CheckOnClick = true;
            clbChuyenNganh.Font = new Font("Times New Roman", 10.2F);
            clbChuyenNganh.FormattingEnabled = true;
            clbChuyenNganh.Items.AddRange(new object[] { "Mạng truyền thông", "Công nghệ phần mềm", "Khoa học máy tính", "Trí tuệ nhân tạo", "Hệ thống thông tin", "Tin học ứng dụng" });
            clbChuyenNganh.Location = new Point(134, 351);
            clbChuyenNganh.Name = "clbChuyenNganh";
            clbChuyenNganh.Size = new Size(223, 136);
            clbChuyenNganh.TabIndex = 11;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 10.2F);
            rdNu.Location = new Point(270, 288);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(51, 23);
            rdNu.TabIndex = 10;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Font = new Font("Times New Roman", 10.2F);
            rdNam.Location = new Point(134, 288);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 23);
            rdNam.TabIndex = 9;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // pbHinh
            // 
            pbHinh.BorderStyle = BorderStyle.Fixed3D;
            pbHinh.Location = new Point(9, 61);
            pbHinh.Name = "pbHinh";
            pbHinh.Size = new Size(156, 160);
            pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinh.TabIndex = 16;
            pbHinh.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ButtonFace;
            btnBrowse.Font = new Font("Times New Roman", 10.2F);
            btnBrowse.Location = new Point(486, 253);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(36, 29);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = ". . . ";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtHinh
            // 
            txtHinh.Font = new Font("Times New Roman", 10.2F);
            txtHinh.Location = new Point(134, 255);
            txtHinh.Name = "txtHinh";
            txtHinh.ReadOnly = true;
            txtHinh.Size = new Size(346, 27);
            txtHinh.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label8.Location = new Point(6, 351);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 13;
            label8.Text = "Chuyên Ngành";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label7.Location = new Point(9, 291);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 12;
            label7.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label6.Location = new Point(9, 259);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 11;
            label6.Text = "Hình";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "CTK31", "CTK32", "CTK33", "CTK34", "CTK32CD", "CTK33CD", "CTK34CD" });
            cboLop.Location = new Point(270, 193);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(252, 28);
            cboLop.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(270, 160);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(252, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(270, 123);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(252, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(270, 90);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(252, 27);
            txtHoTen.TabIndex = 2;
            // 
            // mtxtMaSo
            // 
            mtxtMaSo.Location = new Point(270, 57);
            mtxtMaSo.Mask = "SV.00000";
            mtxtMaSo.Name = "mtxtMaSo";
            mtxtMaSo.Size = new Size(252, 27);
            mtxtMaSo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label5.Location = new Point(181, 197);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 5;
            label5.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label4.Location = new Point(181, 164);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 4;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label3.Location = new Point(181, 129);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 3;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label2.Location = new Point(181, 94);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label1.Location = new Point(181, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 1;
            label1.Text = "Mã số";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(537, 27);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mởFileToolStripMenuItem, thoátToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // mởFileToolStripMenuItem
            // 
            mởFileToolStripMenuItem.Image = (Image)resources.GetObject("mởFileToolStripMenuItem.Image");
            mởFileToolStripMenuItem.Name = "mởFileToolStripMenuItem";
            mởFileToolStripMenuItem.Size = new Size(147, 26);
            mởFileToolStripMenuItem.Text = "Mở File";
            mởFileToolStripMenuItem.Click += mởFileToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = (Image)resources.GetObject("thoátToolStripMenuItem.Image");
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(147, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, sửaToolStripMenuItem, sửaToolStripMenuItem1, listViewToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(51, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Image = (Image)resources.GetObject("thêmToolStripMenuItem.Image");
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.T;
            thêmToolStripMenuItem.Size = new Size(216, 26);
            thêmToolStripMenuItem.Text = "Thêm";
            thêmToolStripMenuItem.Click += thêmToolStripMenuItem_Click;
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Image = (Image)resources.GetObject("sửaToolStripMenuItem.Image");
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Y;
            sửaToolStripMenuItem.Size = new Size(216, 26);
            sửaToolStripMenuItem.Text = "Xóa";
            sửaToolStripMenuItem.Click += sửaToolStripMenuItem_Click;
            // 
            // sửaToolStripMenuItem1
            // 
            sửaToolStripMenuItem1.Image = (Image)resources.GetObject("sửaToolStripMenuItem1.Image");
            sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            sửaToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            sửaToolStripMenuItem1.Size = new Size(216, 26);
            sửaToolStripMenuItem1.Text = "Sửa";
            sửaToolStripMenuItem1.Click += sửaToolStripMenuItem1_Click;
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, màuChữToolStripMenuItem, sắpXếpToolStripMenuItem, tìmKiếmToolStripMenuItem });
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(216, 26);
            listViewToolStripMenuItem.Text = "ListView";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = (Image)resources.GetObject("fontToolStripMenuItem.Image");
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(157, 26);
            fontToolStripMenuItem.Text = "Font";
            // 
            // màuChữToolStripMenuItem
            // 
            màuChữToolStripMenuItem.Image = (Image)resources.GetObject("màuChữToolStripMenuItem.Image");
            màuChữToolStripMenuItem.Name = "màuChữToolStripMenuItem";
            màuChữToolStripMenuItem.Size = new Size(157, 26);
            màuChữToolStripMenuItem.Text = "Màu chữ";
            // 
            // sắpXếpToolStripMenuItem
            // 
            sắpXếpToolStripMenuItem.Image = (Image)resources.GetObject("sắpXếpToolStripMenuItem.Image");
            sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            sắpXếpToolStripMenuItem.Size = new Size(157, 26);
            sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            sắpXếpToolStripMenuItem.Click += sắpXếpToolStripMenuItem_Click;
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.Image = (Image)resources.GetObject("tìmKiếmToolStripMenuItem.Image");
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.Size = new Size(157, 26);
            tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            tìmKiếmToolStripMenuItem.Click += tìmKiếmToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslTongSV });
            statusStrip1.Location = new Point(0, 542);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(743, 25);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "Tổng Sinh Viên: 0";
            // 
            // tsslTongSV
            // 
            tsslTongSV.Font = new Font("Times New Roman", 10F);
            tsslTongSV.Name = "tsslTongSV";
            tsslTongSV.Size = new Size(130, 19);
            tsslTongSV.Text = "Tổng Sinh Viên: 0";
            // 
            // groupboxDSSV
            // 
            groupboxDSSV.Controls.Add(lvSinhVien);
            groupboxDSSV.Dock = DockStyle.Fill;
            groupboxDSSV.Location = new Point(0, 0);
            groupboxDSSV.Name = "groupboxDSSV";
            groupboxDSSV.Size = new Size(743, 567);
            groupboxDSSV.TabIndex = 1;
            groupboxDSSV.TabStop = false;
            groupboxDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            lvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvSinhVien.CheckBoxes = true;
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader7, columnHeader6, columnHeader5, columnHeader8 });
            lvSinhVien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(3, 23);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.RightToLeft = RightToLeft.No;
            lvSinhVien.Size = new Size(737, 556);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Sinh";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa Chỉ";
            columnHeader4.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 6;
            columnHeader7.Text = "Lớp";
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 4;
            columnHeader6.Text = "Phái";
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 5;
            columnHeader5.Text = "Chuyên Ngành";
            columnHeader5.Width = 400;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Hình";
            columnHeader8.Width = 100;
            // 
            // OpenFileDialogHinh
            // 
            OpenFileDialogHinh.AutoUpgradeEnabled = false;
            OpenFileDialogHinh.FileName = "openFileDialog1";
            OpenFileDialogHinh.Filter = "Image File(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            // 
            // ctmsListView
            // 
            ctmsListView.ImageScalingSize = new Size(20, 20);
            ctmsListView.Items.AddRange(new ToolStripItem[] { fontToolStripMenuItem1, màuChữToolStripMenuItem1, sắpXếpToolStripMenuItem1, tìmKiếmToolStripMenuItem1 });
            ctmsListView.Name = "ctmsListView";
            ctmsListView.Size = new Size(144, 108);
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Image = (Image)resources.GetObject("fontToolStripMenuItem1.Image");
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.Size = new Size(143, 26);
            fontToolStripMenuItem1.Text = "Font";
            // 
            // màuChữToolStripMenuItem1
            // 
            màuChữToolStripMenuItem1.Image = (Image)resources.GetObject("màuChữToolStripMenuItem1.Image");
            màuChữToolStripMenuItem1.Name = "màuChữToolStripMenuItem1";
            màuChữToolStripMenuItem1.Size = new Size(143, 26);
            màuChữToolStripMenuItem1.Text = "Màu chữ";
            // 
            // sắpXếpToolStripMenuItem1
            // 
            sắpXếpToolStripMenuItem1.Image = (Image)resources.GetObject("sắpXếpToolStripMenuItem1.Image");
            sắpXếpToolStripMenuItem1.Name = "sắpXếpToolStripMenuItem1";
            sắpXếpToolStripMenuItem1.Size = new Size(143, 26);
            sắpXếpToolStripMenuItem1.Text = "Sắp xếp";
            sắpXếpToolStripMenuItem1.Click += sắpXếpToolStripMenuItem1_Click;
            // 
            // tìmKiếmToolStripMenuItem1
            // 
            tìmKiếmToolStripMenuItem1.Image = (Image)resources.GetObject("tìmKiếmToolStripMenuItem1.Image");
            tìmKiếmToolStripMenuItem1.Name = "tìmKiếmToolStripMenuItem1";
            tìmKiếmToolStripMenuItem1.Size = new Size(143, 26);
            tìmKiếmToolStripMenuItem1.Text = "Tìm kiếm";
            tìmKiếmToolStripMenuItem1.Click += tìmKiếmToolStripMenuItem1_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 567);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "frmSinhVien";
            Text = "Demo Sinh Viên";
            Load += frmSinhVien_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupboxTTSV.ResumeLayout(false);
            groupboxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinh).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupboxDSSV.ResumeLayout(false);
            ctmsListView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupboxTTSV;
        private GroupBox groupboxDSSV;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtMaSo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboLop;
        private TextBox txtDiaChi;
        private TextBox txtHinh;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckedListBox clbChuyenNganh;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private PictureBox pbHinh;
        private Button btnBrowse;
        private Button btnThoat;
        private Button btnMacDinh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ListView lvSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader5;
        private OpenFileDialog OpenFileDialogHinh;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslTongSV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem sửaToolStripMenuItem1;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem màuChữToolStripMenuItem;
        private ToolStripMenuItem sắpXếpToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ContextMenuStrip ctmsListView;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem màuChữToolStripMenuItem1;
        private ToolStripMenuItem sắpXếpToolStripMenuItem1;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem1;
    }
}