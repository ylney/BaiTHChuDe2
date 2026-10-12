namespace MyForm
{
    partial class frmTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrungTam));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rdNam = new RadioButton();
            label4 = new Label();
            rdNu = new RadioButton();
            txtHoTen = new TextBox();
            dtpNgayDangKy = new DateTimePicker();
            chkTinHocA = new CheckBox();
            cboMaHV = new ComboBox();
            chkTinHocB = new CheckBox();
            chkTiengAnhA = new CheckBox();
            chkTiengAnhB = new CheckBox();
            lblTienTHA = new Label();
            lblTienTHB = new Label();
            lblTienTAA = new Label();
            lblTienTAB = new Label();
            label5 = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnCanCel = new Button();
            btnExit = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(16, 90);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 2;
            label1.Text = "Mã Học Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(16, 170);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày Đăng Ký";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Font = new Font("Times New Roman", 10.2F);
            rdNam.Location = new Point(438, 93);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 23);
            rdNam.TabIndex = 1;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.Location = new Point(329, 95);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 10.2F);
            rdNu.Location = new Point(514, 93);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(51, 23);
            rdNu.TabIndex = 2;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 10.2F);
            txtHoTen.Location = new Point(146, 126);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(418, 27);
            txtHoTen.TabIndex = 3;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Font = new Font("Times New Roman", 10.2F);
            dtpNgayDangKy.Location = new Point(146, 165);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(303, 27);
            dtpNgayDangKy.TabIndex = 4;
            // 
            // chkTinHocA
            // 
            chkTinHocA.AutoSize = true;
            chkTinHocA.Font = new Font("Times New Roman", 10.2F);
            chkTinHocA.Location = new Point(80, 224);
            chkTinHocA.Name = "chkTinHocA";
            chkTinHocA.Size = new Size(95, 23);
            chkTinHocA.TabIndex = 5;
            chkTinHocA.Text = "Tin học A";
            chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // cboMaHV
            // 
            cboMaHV.Font = new Font("Times New Roman", 10.2F);
            cboMaHV.FormattingEnabled = true;
            cboMaHV.Items.AddRange(new object[] { "001", "002", "003", "004", "005" });
            cboMaHV.Location = new Point(146, 87);
            cboMaHV.Name = "cboMaHV";
            cboMaHV.Size = new Size(166, 27);
            cboMaHV.TabIndex = 0;
            // 
            // chkTinHocB
            // 
            chkTinHocB.AutoSize = true;
            chkTinHocB.Font = new Font("Times New Roman", 10.2F);
            chkTinHocB.Location = new Point(79, 265);
            chkTinHocB.Name = "chkTinHocB";
            chkTinHocB.Size = new Size(96, 23);
            chkTinHocB.TabIndex = 6;
            chkTinHocB.Text = "Tin học B";
            chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            chkTiengAnhA.AutoSize = true;
            chkTiengAnhA.Font = new Font("Times New Roman", 10.2F);
            chkTiengAnhA.Location = new Point(79, 308);
            chkTiengAnhA.Name = "chkTiengAnhA";
            chkTiengAnhA.Size = new Size(112, 23);
            chkTiengAnhA.TabIndex = 7;
            chkTiengAnhA.Text = "Tiếng Anh A";
            chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            chkTiengAnhB.AutoSize = true;
            chkTiengAnhB.Font = new Font("Times New Roman", 10.2F);
            chkTiengAnhB.Location = new Point(79, 351);
            chkTiengAnhB.Name = "chkTiengAnhB";
            chkTiengAnhB.Size = new Size(113, 23);
            chkTiengAnhB.TabIndex = 8;
            chkTiengAnhB.Text = "Tiếng Anh B";
            chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTienTHA
            // 
            lblTienTHA.AutoSize = true;
            lblTienTHA.Font = new Font("Times New Roman", 10.2F);
            lblTienTHA.Location = new Point(396, 225);
            lblTienTHA.Name = "lblTienTHA";
            lblTienTHA.Size = new Size(105, 19);
            lblTienTHA.TabIndex = 2;
            lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            lblTienTHB.AutoSize = true;
            lblTienTHB.Font = new Font("Times New Roman", 10.2F);
            lblTienTHB.Location = new Point(396, 266);
            lblTienTHB.Name = "lblTienTHB";
            lblTienTHB.Size = new Size(105, 19);
            lblTienTHB.TabIndex = 2;
            lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAA
            // 
            lblTienTAA.AutoSize = true;
            lblTienTAA.Font = new Font("Times New Roman", 10.2F);
            lblTienTAA.Location = new Point(395, 309);
            lblTienTAA.Name = "lblTienTAA";
            lblTienTAA.Size = new Size(105, 19);
            lblTienTAA.TabIndex = 2;
            lblTienTAA.Text = "400.000 đồng";
            // 
            // lblTienTAB
            // 
            lblTienTAB.AutoSize = true;
            lblTienTAB.Font = new Font("Times New Roman", 10.2F);
            lblTienTAB.Location = new Point(395, 352);
            lblTienTAB.Name = "lblTienTAB";
            lblTienTAB.Size = new Size(105, 19);
            lblTienTAB.TabIndex = 2;
            lblTienTAB.Text = "600.000 đồng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(146, 395);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 2;
            label5.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Times New Roman", 10.2F);
            txtTongTien.Location = new Point(231, 392);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(205, 27);
            txtTongTien.TabIndex = 9;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.LavenderBlush;
            btnTinhTien.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnTinhTien.ForeColor = Color.MediumVioletRed;
            btnTinhTien.Location = new Point(16, 444);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(161, 61);
            btnTinhTien.TabIndex = 11;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnCanCel
            // 
            btnCanCel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCanCel.ForeColor = Color.Red;
            btnCanCel.Image = (Image)resources.GetObject("btnCanCel.Image");
            btnCanCel.Location = new Point(213, 444);
            btnCanCel.Name = "btnCanCel";
            btnCanCel.Size = new Size(223, 61);
            btnCanCel.TabIndex = 10;
            btnCanCel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanCel.UseVisualStyleBackColor = true;
            btnCanCel.Click += btnCanCel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Honeydew;
            btnExit.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(460, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 61);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(16, 18);
            label6.Name = "label6";
            label6.Size = new Size(615, 48);
            label6.TabIndex = 1;
            label6.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // frmTrungTam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 526);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnCanCel);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(label5);
            Controls.Add(lblTienTAB);
            Controls.Add(lblTienTAA);
            Controls.Add(lblTienTHB);
            Controls.Add(lblTienTHA);
            Controls.Add(chkTiengAnhB);
            Controls.Add(chkTiengAnhA);
            Controls.Add(chkTinHocB);
            Controls.Add(cboMaHV);
            Controls.Add(chkTinHocA);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(txtHoTen);
            Controls.Add(rdNu);
            Controls.Add(label4);
            Controls.Add(rdNam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTrungTam";
            Text = "frmTrungTam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rdNam;
        private Label label4;
        private RadioButton rdNu;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgayDangKy;
        private CheckBox chkTinHocA;
        private ComboBox cboMaHV;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhA;
        private CheckBox chkTiengAnhB;
        private Label lblTienTHA;
        private Label lblTienTHB;
        private Label lblTienTAA;
        private Label lblTienTAB;
        private Label label5;
        private TextBox txtTongTien;
        private Button btnTinhTien;
        private Button btnCanCel;
        private Button btnExit;
        private Label label6;
    }
}
