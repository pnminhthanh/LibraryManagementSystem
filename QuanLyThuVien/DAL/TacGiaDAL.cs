using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class TacGiaDAL
    {
        public List<TacGia> LayDSTacGia()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listTacGia = from tacGia in ThuVienDS.TacGias select tacGia;
                return listTacGia.ToList();
            }
        }

        public bool ThemTacGia(TacGia tacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.TacGias.Add(tacGia);
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool CapNhatTacGia(TacGia tacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var tGia = ThuVienDS.TacGias.Find(tacGia.MaTacGia);
                tGia = tacGia;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaTacGia(string maTacGia)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var tGia = ThuVienDs.TacGias.Find(maTacGia);
                ThuVienDs.TacGias.Remove(tGia);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<TacGia> TimKiemTacGia(TacGia tacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listTacGia = from r in ThuVienDS.TacGias select r;
                if (tacGia.MaTacGia != "none")
                    listTacGia = listTacGia.Where<TacGia>(c => c.MaTacGia.Contains(tacGia.MaTacGia));
                if (tacGia.TenTacGia != "none")
                    listTacGia = listTacGia.Where<TacGia>(c => c.TenTacGia.Contains(tacGia.TenTacGia));
                if (tacGia.GioiTinh != "none")
                    listTacGia = listTacGia.Where<TacGia>(c => c.GioiTinh.Equals(tacGia.GioiTinh));
                if (tacGia.NgaySinh != Convert.ToDateTime(01/01/01))
                    listTacGia = listTacGia.Where<TacGia>(c => Convert.ToString(c.NgaySinh).Contains(tacGia.TenTacGia));
                return listTacGia.ToList();
            }
        }

        public TacGia LayTGTheoMa(string maTacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                TacGia tacGia = ThuVienDS.TacGias.Find(maTacGia);
                return tacGia;
            }            
        }
    }
}
