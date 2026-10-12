namespace MyForm
{
    partial class frmGiangVien
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
            lblThongBao = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cboMaSo = new ComboBox();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtHoTen = new TextBox();
            mtxtSoDT = new MaskedTextBox();
            dtpNgaySinh = new DateTimePicker();
            txtMail = new TextBox();
            chklbNgoaiNgu = new CheckedListBox();
            lbDanhSachHP = new ListBox();
            lbHocPhanDay = new ListBox();
            btnChon = new Button();
            btnXoa = new Button();
            btnExit = new Button();
            btnCanCel = new Button();
            btnthongBao = new Button();
            linklbLienHe = new LinkLabel();
            label10 = new Label();
            btnThem = new Button();
            btnTim = new Button();
            SuspendLayout();
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.BlueViolet;
            lblThongBao.Location = new Point(47, 9);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(793, 48);
            lblThongBao.TabIndex = 2;
            lblThongBao.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 3;
            label1.Text = "Mã Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 155);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 4;
            label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 5;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 206);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 6;
            label4.Text = "Ngoại Ngữ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(510, 72);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 7;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 113);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 8;
            label6.Text = "Số ĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(510, 159);
            label7.Name = "label7";
            label7.Size = new Size(100, 19);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(133, 317);
            label8.Name = "label8";
            label8.Size = new Size(149, 19);
            label8.TabIndex = 10;
            label8.Text = "Danh sách môn học";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(510, 317);
            label9.Name = "label9";
            label9.Size = new Size(173, 19);
            label9.TabIndex = 11;
            label9.Text = "Môn học giáo viên dạy";
            // 
            // cboMaSo
            // 
            cboMaSo.FormattingEnabled = true;
            cboMaSo.Items.AddRange(new object[] { "001", "002", "003", "004" });
            cboMaSo.Location = new Point(133, 64);
            cboMaSo.Name = "cboMaSo";
            cboMaSo.Size = new Size(222, 28);
            cboMaSo.TabIndex = 12;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(631, 69);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 13;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(721, 68);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(50, 24);
            rdNu.TabIndex = 14;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(133, 105);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(222, 27);
            txtHoTen.TabIndex = 15;
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Location = new Point(631, 109);
            mtxtSoDT.Mask = "(\\0633).000.000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(174, 27);
            mtxtSoDT.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(133, 149);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(222, 27);
            dtpNgaySinh.TabIndex = 17;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(631, 155);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(209, 27);
            txtMail.TabIndex = 18;
            // 
            // chklbNgoaiNgu
            // 
            chklbNgoaiNgu.FormattingEnabled = true;
            chklbNgoaiNgu.Items.AddRange(new object[] { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật", "Tiếng Nga" });
            chklbNgoaiNgu.Location = new Point(133, 206);
            chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            chklbNgoaiNgu.Size = new Size(156, 92);
            chklbNgoaiNgu.TabIndex = 19;
            // 
            // lbDanhSachHP
            // 
            lbDanhSachHP.FormattingEnabled = true;
            lbDanhSachHP.Items.AddRange(new object[] { "Tin học cơ sở", "Lập trình cấu trúc C/C++", "Cơ sở dữ liệu", "Tiếng Anh B1", "Tiếng Anh B2", "Lập trình hướng đối tượng", "Mạng máy tính ", "Công nghệ phần mềm", "Phân tích TKHDT" });
            lbDanhSachHP.Location = new Point(133, 339);
            lbDanhSachHP.Name = "lbDanhSachHP";
            lbDanhSachHP.SelectionMode = SelectionMode.MultiExtended;
            lbDanhSachHP.Size = new Size(222, 184);
            lbDanhSachHP.TabIndex = 20;
            // 
            // lbHocPhanDay
            // 
            lbHocPhanDay.FormattingEnabled = true;
            lbHocPhanDay.Location = new Point(510, 339);
            lbHocPhanDay.Name = "lbHocPhanDay";
            lbHocPhanDay.Size = new Size(222, 184);
            lbHocPhanDay.TabIndex = 21;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(384, 387);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(94, 29);
            btnChon.TabIndex = 22;
            btnChon.Text = ">>";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(384, 444);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "<<";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Honeydew;
            btnExit.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnExit.ForeColor = Color.DarkGreen;
            btnExit.Location = new Point(346, 565);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 57);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCanCel
            // 
            btnCanCel.BackColor = Color.Snow;
            btnCanCel.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnCanCel.ForeColor = Color.Red;
            btnCanCel.Location = new Point(179, 565);
            btnCanCel.Name = "btnCanCel";
            btnCanCel.Size = new Size(161, 57);
            btnCanCel.TabIndex = 25;
            btnCanCel.Text = "Cancel";
            btnCanCel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanCel.UseVisualStyleBackColor = false;
            btnCanCel.Click += btnCancel_Click;
            // 
            // btnthongBao
            // 
            btnthongBao.BackColor = Color.Lavender;
            btnthongBao.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnthongBao.ForeColor = Color.Indigo;
            btnthongBao.Location = new Point(12, 563);
            btnthongBao.Name = "btnthongBao";
            btnthongBao.Size = new Size(161, 61);
            btnthongBao.TabIndex = 26;
            btnthongBao.Text = "Thông Báo";
            btnthongBao.UseVisualStyleBackColor = false;
            btnthongBao.Click += btnThongBao_Click;
            // 
            // linklbLienHe
            // 
            linklbLienHe.AutoSize = true;
            linklbLienHe.Location = new Point(785, 634);
            linklbLienHe.Name = "linklbLienHe";
            linklbLienHe.Size = new Size(56, 20);
            linklbLienHe.TabIndex = 27;
            linklbLienHe.TabStop = true;
            linklbLienHe.Text = "Liên hệ";
            linklbLienHe.LinkClicked += linklbLienHe_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(701, 635);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 28;
            label10.Text = "Website";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.AliceBlue;
            btnThem.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnThem.ForeColor = Color.DarkSlateBlue;
            btnThem.Location = new Point(513, 565);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(161, 57);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Linen;
            btnTim.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnTim.ForeColor = Color.SaddleBrown;
            btnTim.Location = new Point(680, 563);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(161, 55);
            btnTim.TabIndex = 30;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // frmGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 663);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(label10);
            Controls.Add(linklbLienHe);
            Controls.Add(btnExit);
            Controls.Add(btnCanCel);
            Controls.Add(btnthongBao);
            Controls.Add(btnXoa);
            Controls.Add(btnChon);
            Controls.Add(lbHocPhanDay);
            Controls.Add(lbDanhSachHP);
            Controls.Add(chklbNgoaiNgu);
            Controls.Add(txtMail);
            Controls.Add(dtpNgaySinh);
            Controls.Add(mtxtSoDT);
            Controls.Add(txtHoTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(cboMaSo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblThongBao);
            Name = "frmGiangVien";
            Text = "Giảng viên";
            Load += frmGiangVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongBao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cboMaSo;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtSoDT;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMail;
        private CheckedListBox chklbNgoaiNgu;
        private ListBox lbDanhSachHP;
        private ListBox lbHocPhanDay;
        private Button btnChon;
        private Button btnXoa;
        private Button btnExit;
        private Button btnCanCel;
        private Button btnthongBao;
        private LinkLabel linklbLienHe;
        private Label label10;
        private Button btnThem;
        private Button btnTim;
    }
}