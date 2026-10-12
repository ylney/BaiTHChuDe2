namespace MyForm
{
    partial class frmTuyChon
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
            groupBoxTim = new GroupBox();
            rdNgaySinh = new RadioButton();
            rdHoTen = new RadioButton();
            rdMaSV = new RadioButton();
            label1 = new Label();
            txtThongTin = new TextBox();
            btnTim = new Button();
            btnThoat = new Button();
            btnSapXep = new Button();
            groupBoxTimTT = new GroupBox();
            groupBoxTim.SuspendLayout();
            groupBoxTimTT.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTim
            // 
            groupBoxTim.Controls.Add(rdNgaySinh);
            groupBoxTim.Controls.Add(rdHoTen);
            groupBoxTim.Controls.Add(rdMaSV);
            groupBoxTim.Font = new Font("Times New Roman", 10.2F);
            groupBoxTim.Location = new Point(39, 27);
            groupBoxTim.Name = "groupBoxTim";
            groupBoxTim.Size = new Size(420, 71);
            groupBoxTim.TabIndex = 0;
            groupBoxTim.TabStop = false;
            // 
            // rdNgaySinh
            // 
            rdNgaySinh.AutoSize = true;
            rdNgaySinh.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdNgaySinh.ForeColor = Color.Blue;
            rdNgaySinh.Location = new Point(287, 26);
            rdNgaySinh.Name = "rdNgaySinh";
            rdNgaySinh.Size = new Size(115, 26);
            rdNgaySinh.TabIndex = 2;
            rdNgaySinh.Text = "Ngày Sinh";
            rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            rdHoTen.AutoSize = true;
            rdHoTen.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdHoTen.ForeColor = Color.Blue;
            rdHoTen.Location = new Point(160, 26);
            rdHoTen.Name = "rdHoTen";
            rdHoTen.Size = new Size(92, 26);
            rdHoTen.TabIndex = 1;
            rdHoTen.Text = "Họ Tên";
            rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSV
            // 
            rdMaSV.AutoSize = true;
            rdMaSV.Checked = true;
            rdMaSV.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdMaSV.ForeColor = Color.Blue;
            rdMaSV.Location = new Point(23, 26);
            rdMaSV.Name = "rdMaSV";
            rdMaSV.Size = new Size(88, 26);
            rdMaSV.TabIndex = 0;
            rdMaSV.TabStop = true;
            rdMaSV.Text = "Mã SV";
            rdMaSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(51, 147);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 3;
            label1.Text = "Nhập Thông Tin";
            // 
            // txtThongTin
            // 
            txtThongTin.Font = new Font("Times New Roman", 10.2F);
            txtThongTin.Location = new Point(183, 140);
            txtThongTin.Name = "txtThongTin";
            txtThongTin.Size = new Size(189, 27);
            txtThongTin.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Lavender;
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnTim.ForeColor = Color.Indigo;
            btnTim.Location = new Point(339, 23);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 27);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Lavender;
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Indigo;
            btnThoat.Location = new Point(278, 193);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 35);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnSapXep
            // 
            btnSapXep.BackColor = Color.MintCream;
            btnSapXep.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSapXep.ForeColor = Color.DarkGreen;
            btnSapXep.Location = new Point(62, 193);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(94, 35);
            btnSapXep.TabIndex = 7;
            btnSapXep.Text = "Sắp Xếp";
            btnSapXep.UseVisualStyleBackColor = false;
            btnSapXep.Click += btnSapXep_Click_1;
            // 
            // groupBoxTimTT
            // 
            groupBoxTimTT.Controls.Add(btnTim);
            groupBoxTimTT.Font = new Font("Times New Roman", 10.2F);
            groupBoxTimTT.Location = new Point(39, 117);
            groupBoxTimTT.Name = "groupBoxTimTT";
            groupBoxTimTT.Size = new Size(420, 70);
            groupBoxTimTT.TabIndex = 3;
            groupBoxTimTT.TabStop = false;
            // 
            // frmTuyChon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 253);
            Controls.Add(btnSapXep);
            Controls.Add(btnThoat);
            Controls.Add(txtThongTin);
            Controls.Add(label1);
            Controls.Add(groupBoxTim);
            Controls.Add(groupBoxTimTT);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTuyChon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tùy chọn";
            groupBoxTim.ResumeLayout(false);
            groupBoxTim.PerformLayout();
            groupBoxTimTT.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTim;
        private RadioButton rdNgaySinh;
        private RadioButton rdHoTen;
        private RadioButton rdMaSV;
        private Label label1;
        private TextBox txtThongTin;
        private Button btnTim;
        private Button btnThoat;
        private Button btnSapXep;
        private GroupBox groupBoxTimTT;
    }
}