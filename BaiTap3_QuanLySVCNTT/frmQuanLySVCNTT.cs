using System.Drawing;

namespace BaiTap3_QuanLySVCNTT
{
    public partial class frmQuanLySVCNTT : Form
    {
        QuanLySinhVien qlsv;
        bool isModified = false; 

        public frmQuanLySVCNTT()
        {
            InitializeComponent();
        }

        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MSSV.CompareTo(sv1.ToString());
        }

        private void ThemSV_LV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV_LV(sv);
            }
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = this.mtxtMSSV.Text.Trim();
            sv.HoTen = this.txtHoTen.Text.Trim();
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.GioiTinh = this.rdNam.Checked;
            sv.Lop = this.cboLop.Text;
            sv.SoDT = this.mtxtSoDT.Text;
            sv.Email = this.txtEmail.Text.Trim();
            sv.DiaChi = this.txtDiaChi.Text.Trim();
            sv.Hinh = this.txtHinh.Text;
            return sv;
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh) this.rdNam.Checked = true;
            else this.rdNu.Checked = true;
            this.cboLop.Text = sv.Lop;
            this.mtxtSoDT.Text = sv.SoDT;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtHinh.Text = sv.Hinh;

            try { this.pbHinh.ImageLocation = sv.Hinh; }
            catch { this.pbHinh.ImageLocation = ""; }
        }

        private void frmQuanLySVCNTT_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile("DSNV.txt"); 
            LoadListView();
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (ofdHinh.ShowDialog() == DialogResult.OK)
            {
                this.txtHinh.Text = ofdHinh.FileName;
                this.pbHinh.ImageLocation = ofdHinh.FileName;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.cboLop.SelectedIndex = 0;
            this.mtxtSoDT.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV, SoSanhTheoMa);

            if (kq != null)
            {
                qlsv.Sua(sv, sv.MSSV, SoSanhTheoMa);
            }
            else
            {
                qlsv.Them(sv);
            }

            LoadListView();
            isModified = true;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                string mssv = this.lvSinhVien.SelectedItems[0].SubItems[0].Text;
                SinhVien sv = qlsv.Tim(mssv, SoSanhTheoMa);
                if (sv != null) ThietLapThongTin(sv);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    ListViewItem lvitem = this.lvSinhVien.SelectedItems[i];
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
                    LoadListView();
                    btnMacDinh.PerformClick();
                    isModified = true;
                }
            }
        }

        private void tsmiTaiLai_Click(object sender, EventArgs e)
        {

            qlsv.dsSinhVien.Clear();
            qlsv.DocTuFile("DSNV.txt");
            LoadListView();
            isModified = false;
        }

        private void frmQuanLySVCNTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult rs = MessageBox.Show("Danh sách đã thay đổi. Bạn có muốn lưu lại không?", "Xác nhận lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (rs == DialogResult.OK)
                {
                    qlsv.GhiRaFile("DSNV.txt");
                }
                else if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}