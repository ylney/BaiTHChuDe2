namespace MyForm
{
    partial class frmTBGiangVien
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
            SuspendLayout();
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Times New Roman", 12F);
            lblThongBao.ForeColor = Color.BlueViolet;
            lblThongBao.Location = new Point(236, 160);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(60, 22);
            lblThongBao.TabIndex = 0;
            lblThongBao.Text = "label1";
            // 
            // frmTBGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblThongBao);
            Name = "frmTBGiangVien";
            Text = "frmTBGiangVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongBao;
    }
}