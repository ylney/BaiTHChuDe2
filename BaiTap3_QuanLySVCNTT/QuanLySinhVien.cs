using System;
using System.Collections; 
using System.IO;

namespace BaiTap3_QuanLySVCNTT
{
    public delegate int SoSanh(object sv1, object sv2);

    public class QuanLySinhVien
    {
        public ArrayList dsSinhVien; 

        public QuanLySinhVien()
        {
            dsSinhVien = new ArrayList(); 
        }

        public SinhVien this[int index]
        {
            get { return (SinhVien)this.dsSinhVien[index]; } 
            set { dsSinhVien[index] = value; }
        }

        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dsSinhVien)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dsSinhVien.Count;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = this.dsSinhVien.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.dsSinhVien.RemoveAt(i);
        }

        public void DocTuFile(string filename)
        {
            if (!File.Exists(filename)) return;
            string t;
            string[] s;
            SinhVien sv;
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    if (s.Length >= 9)
                    {
                        sv = new SinhVien();
                        sv.MSSV = s[0];
                        sv.HoTen = s[1];
                        sv.GioiTinh = (s[2] == "1");
                        sv.NgaySinh = DateTime.Parse(s[3]);
                        sv.Lop = s[4];
                        sv.SoDT = s[5];
                        sv.Email = s[6];
                        sv.DiaChi = s[7];
                        sv.Hinh = s[8];
                        this.Them(sv);
                    }
                }
            }
        }

        public void GhiRaFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create)))
            {
                foreach (SinhVien sv in dsSinhVien)
                {
                    string gt = sv.GioiTinh ? "1" : "0";
                    sw.WriteLine($"{sv.MSSV}\t{sv.HoTen}\t{gt}\t{sv.NgaySinh}\t{sv.Lop}\t{sv.SoDT}\t{sv.Email}\t{sv.DiaChi}\t{sv.Hinh}");
                }
            }
        }
    }
}