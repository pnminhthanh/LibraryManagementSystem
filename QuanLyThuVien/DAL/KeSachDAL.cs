using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class KeSachDAL
    {
        public List<KeSach> LayDSKeSach()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListKeSach = from keSach in ThuVienDS.KeSaches select keSach;
                return ListKeSach.ToList();
            }
        }

        public bool ThemKeSach(KeSach keSach)
        {
            using (var ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.KeSaches.Add(keSach);
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool CapNhatKeSach(KeSach keSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ke = ThuVienDS.KeSaches.Find(keSach.MaKeSach);
                ke = keSach;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaKeSach(string maKeSach)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var ke = ThuVienDs.KeSaches.Find(maKeSach);
                ThuVienDs.KeSaches.Remove(ke);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<KeSach> TimKiemKeSach(KeSach keSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listKeSach = from ke in ThuVienDS.KeSaches select ke;
                if (keSach.MaKeSach != "none")
                    listKeSach = listKeSach.Where<KeSach>(c => c.MaKeSach.Contains(keSach.MaKeSach));                
                return listKeSach.ToList();
            }
        }

        public KeSach LayKeSachTheoMa(string maKeSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                KeSach keSach = ThuVienDS.KeSaches.Find(maKeSach);                
                return keSach;
            }
        }
    }
}
