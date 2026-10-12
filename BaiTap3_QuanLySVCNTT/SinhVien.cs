using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_QuanLySVCNTT
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; } 
        public string Lop { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }

        public SinhVien() { }

        public SinhVien(string ms, string ht, DateTime ngay, bool gt, string lop, string sdt, string email, string dc, string hinh)
        {
            this.MSSV = ms;
            this.HoTen = ht;
            this.NgaySinh = ngay;
            this.GioiTinh = gt;
            this.Lop = lop;
            this.SoDT = sdt;
            this.Email = email;
            this.DiaChi = dc;
            this.Hinh = hinh;
        }
    }
}
