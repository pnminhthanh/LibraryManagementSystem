using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class KhoChuaDAL
    {
        public List<KhoSach> LayDSKhoSach()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListKhoSach = from kho in ThuVienDS.KhoSaches select kho;
                return ListKhoSach.ToList();
            }
        }

        public bool ThemKhoSach(KhoSach khoSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.KhoSaches.Add(khoSach);
            }
            return true;
        }

        public bool CapNhatKhoSach(KhoSach khoSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var kSach = ThuVienDS.KhoSaches.Find(khoSach.MaKhoSach);
                kSach = khoSach;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaKhoSach(KhoSach khoSach)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var kSach = ThuVienDs.KhoSaches.Find(khoSach.MaKhoSach);
                ThuVienDs.KhoSaches.Remove(kSach);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<KhoSach> TimKiemKhoSach(KhoSach khosach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listKhoSach = from r in ThuVienDS.KhoSaches select r;
                if (khosach.MaKhoSach != "none")
                    listKhoSach = listKhoSach.Where<KhoSach>(c => c.MaKhoSach.Contains(khosach.MaKhoSach));
                if (khosach.TenKhoSach != "none")
                    listKhoSach = listKhoSach.Where<KhoSach>(c => c.TenKhoSach.Contains(khosach.TenKhoSach));
                return listKhoSach.ToList();
            }
        }

        public List<KeSach> LocKeSachTheoKho(string maKhoSach)
        {
            using (QLThuVienEntities thuVienDS = new QLThuVienEntities())
            {
                var listKeSach = from k in thuVienDS.KeSaches where k.MaKhoSach == maKhoSach select k;
                return listKeSach.ToList();
            }
        }
    }
}
