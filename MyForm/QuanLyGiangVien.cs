using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }

    public delegate int SoSanh(object a, object b);

    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien;

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }
            set { dsGiangVien[index] = value; }
        }

        public bool Them(GiangVien gv)
        {
            foreach (GiangVien item in dsGiangVien)
            {
                if (item.MaSo == gv.MaSo) return false;
            }
            dsGiangVien.Add(gv);
            return true;
        }

        public GiangVien Tim(object temp, SoSanh ss)
        {
            foreach (GiangVien gv in dsGiangVien)
            {
                if (ss(temp, gv) == 0) return gv;
            }
            return null;
        }
    }
}