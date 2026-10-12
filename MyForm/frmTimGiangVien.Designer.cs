namespace MyForm
{
    partial class frmTimGiangVien
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
            grTim = new GroupBox();
            rdSoDT = new RadioButton();
            rdHoTen = new RadioButton();
            rdMaGV = new RadioButton();
            btnOk = new Button();
            txtTuKhoa = new TextBox();
            label11 = new Label();
            grTim.SuspendLayout();
            SuspendLayout();
            // 
            // grTim
            // 
            grTim.Controls.Add(rdSoDT);
            grTim.Controls.Add(rdHoTen);
            grTim.Controls.Add(rdMaGV);
            grTim.Location = new Point(35, 24);
            grTim.Name = "grTim";
            grTim.Size = new Size(452, 72);
            grTim.TabIndex = 32;
            grTim.TabStop = false;
            grTim.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            rdSoDT.AutoSize = true;
            rdSoDT.Font = new Font("Times New Roman", 10.2F);
            rdSoDT.Location = new Point(272, 26);
            rdSoDT.Name = "rdSoDT";
            rdSoDT.Size = new Size(127, 23);
            rdSoDT.TabIndex = 2;
            rdSoDT.Text = "Số Điện Thoại";
            rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            rdHoTen.AutoSize = true;
            rdHoTen.Font = new Font("Times New Roman", 10.2F);
            rdHoTen.Location = new Point(144, 26);
            rdHoTen.Name = "rdHoTen";
            rdHoTen.Size = new Size(80, 23);
            rdHoTen.TabIndex = 1;
            rdHoTen.Text = "Họ Tên";
            rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaGV
            // 
            rdMaGV.AutoSize = true;
            rdMaGV.Checked = true;
            rdMaGV.Font = new Font("Times New Roman", 10.2F);
            rdMaGV.Location = new Point(27, 26);
            rdMaGV.Name = "rdMaGV";
            rdMaGV.Size = new Size(79, 23);
            rdMaGV.TabIndex = 0;
            rdMaGV.TabStop = true;
            rdMaGV.Text = "Mã GV";
            rdMaGV.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.AliceBlue;
            btnOk.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnOk.ForeColor = Color.MidnightBlue;
            btnOk.Location = new Point(385, 116);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 29);
            btnOk.TabIndex = 5;
            btnOk.Text = "Tìm";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOK_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Times New Roman", 10.2F);
            txtTuKhoa.Location = new Point(103, 118);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(276, 27);
            txtTuKhoa.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label11.Location = new Point(35, 121);
            label11.Name = "label11";
            label11.Size = new Size(62, 19);
            label11.TabIndex = 3;
            label11.Text = "Mã GV";
            // 
            // frmTimGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 179);
            Controls.Add(btnOk);
            Controls.Add(grTim);
            Controls.Add(txtTuKhoa);
            Controls.Add(label11);
            Name = "frmTimGiangVien";
            Text = "frmTimGiangVien";
            grTim.ResumeLayout(false);
            grTim.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grTim;
        private Button btnOk;
        private TextBox txtTuKhoa;
        private Label label11;
        private RadioButton rdSoDT;
        private RadioButton rdHoTen;
        private RadioButton rdMaGV;
    }
}