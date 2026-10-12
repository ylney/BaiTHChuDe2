using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm
{
    public enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }
    class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;
        public QuanLySinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }
        public SinhVien this[int index]
        {
            get { return this.dsSinhVien[index]; }
            set { dsSinhVien[index] = value; }
        }

        // 1. Thêm sinh viên
        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }

        // 2. Tìm sinh viên đầu tiên thỏa điều kiện so sánh
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dsSinhVien)
            {
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }

        // 3. Sửa thông tin sinh viên thỏa điều kiện so sánh
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int count = this.dsSinhVien.Count;
            bool kq = false;
            for (int i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

        // 4. Xóa thông tin sinh viên thỏa điều kiện so sánh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = this.dsSinhVien.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this.dsSinhVien.RemoveAt(i);
                }
            }
        }

        // 5. Đọc danh sách từ file text
        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            SinhVien sv;
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    sv = new SinhVien();
                    sv.MaSo = s[0];
                    sv.HoTen = s[1];
                    sv.NgaySinh = DateTime.Parse(s[2]);
                    sv.DiaChi = s[3];
                    sv.Lop = s[4];
                    sv.Hinh = s[5];
                    sv.GioiTinh = false;

                    if (s[6] == "1")
                        sv.GioiTinh = true;

                    string[] cn = s[7].Split(','); 
                    foreach (string c in cn)
                    {
                        sv.ChuyenNganh.Add(c);
                    }

                    this.Them(sv);
                }
            }
        }
        
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < dsSinhVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsSinhVien.Count; j++)
                {
                    if (ss(dsSinhVien[i], dsSinhVien[j]) > 0)
                    {
                        SinhVien temp = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = temp;
                    }
                }
            }
        }

        public SinhVien TimKiem(string chuoiTim, TuyChon kieu)
        {
            foreach (SinhVien sv in dsSinhVien)
            {
                switch (kieu)
                {
                    case TuyChon.MaSV:
                        if (sv.MaSo.Contains(chuoiTim)) return sv;
                        break;
                    case TuyChon.HoTen:
                        if (sv.HoTen.Contains(chuoiTim)) return sv;
                        break;
                    case TuyChon.NgaySinh:
                        if (sv.NgaySinh.ToString("dd/MM/yyyy").Contains(chuoiTim)) return sv;
                        break;
                }
            }
            return null; 
        }
    }
}
