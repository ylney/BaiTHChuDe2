using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class frmTuyChon : Form
    {
        public TuyChon Kieu;
        public string ChuoiTim;
        private bool isTimKiem;

        public frmTuyChon()
        {
            InitializeComponent();
        }

        public frmTuyChon(bool isTimKiem)
        {
            InitializeComponent();
            this.isTimKiem = isTimKiem;
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            if (isTimKiem)
            {
                txtThongTin.Enabled = true;
                btnTim.Enabled = true;
                btnSapXep.Enabled = false;
            }
            else
            {
                txtThongTin.Enabled = false;
                btnTim.Enabled = false;
                btnSapXep.Enabled = true;
            }
        }

        private void DetermineKieu()
        {
            if (rdMaSV.Checked) Kieu = TuyChon.MaSV;
            else if (rdHoTen.Checked) Kieu = TuyChon.HoTen;
            else if (rdNgaySinh.Checked) Kieu = TuyChon.NgaySinh;
        }

        private void btnSapXep_Click_1(object sender, EventArgs e)
        {
            DetermineKieu();
            this.DialogResult = DialogResult.OK;
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            ChuoiTim = txtThongTin.Text.Trim();
            if (string.IsNullOrEmpty(ChuoiTim))
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetermineKieu();
            this.DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
