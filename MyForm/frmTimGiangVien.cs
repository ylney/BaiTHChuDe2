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
    public partial class frmTimGiangVien : Form
    {
        QuanLyGiangVien qlgv;

        public frmTimGiangVien(QuanLyGiangVien ql)
        {
            InitializeComponent();
            this.qlgv = ql;
        }

        private int SoSanhTheoMa(object a, object b)
        {
            GiangVien gv = b as GiangVien;
            return gv.MaSo.CompareTo(a.ToString());
        }

        private int SoSanhTheoTen(object a, object b)
        {
            GiangVien gv = b as GiangVien;
            return gv.HoTen.CompareTo(a.ToString());
        }

        private int SoSanhTheoSDT(object a, object b)
        {
            GiangVien gv = b as GiangVien;
            return gv.SoDT.CompareTo(a.ToString());
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            GiangVien kq = null;
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (rdMaGV.Checked)
                kq = qlgv.Tim(tuKhoa, SoSanhTheoMa);
            else if (rdHoTen.Checked)
                kq = qlgv.Tim(tuKhoa, SoSanhTheoTen);
            else if (rdSoDT.Checked)
                kq = qlgv.Tim(tuKhoa, SoSanhTheoSDT);

            if (kq != null)
            {
                frmTBGiangVien frm = new frmTBGiangVien();
                frm.SetText(kq.ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
